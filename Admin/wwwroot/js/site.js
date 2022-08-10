let windowHeight;
let tableContainer; // on index pages, this is the scrollable div that surrounds the main table
let footer;
let localStorageScrollStr = "CCG_CCT_WindowScroll";

// these three variables are used on the All Position Details page and hold table rows
let APDAllTableRows;
let APDHeaderRow;
let APDNonHeaderRows;

const ALL = 1, RESULTS = 2, NO_RESULTS = 3; // used in the all position details page
const EMPTY_CERT_DESC_ID = 1;
const ENCODED_AMPERSAND = encodeURIComponent("&");
const MARGIN_BETWEEN_FOOTER_AND_TABLE = 30; // the number of pixels that should be between the footer and the tableContainer

// Utility functions VVVVV -----------------------------------------------------------------------------------------------------------------

/**
 * The same as the querySelectorAll function, expect this one returns an array of HTMLElements, and it is not called on anything. An optional parent parameter can simply be passed, otherwise the document will be used. Returns an empty array in case no elements match.
 * 
 * @param {string} selector - The string which represents the desired selection
 * @param {HTMLElement} parent - Optional: the parent on which the selection is made (default is document)
 * @returns HTMLElement[] | []
 * 
 */
function qsa(selector, parent = document) {
    if ((!selector) || (!parent)) {
        return [];
    }
    return (/** @type {HTMLElement[]} */ ([...parent.querySelectorAll(selector)]));
}

/**
 * The same querySelector function that you know, expect this one returns a HTMLElement, and you don't call it on anything, you can simply pass an optional parent parameter to it.
 * 
 * @param {string} selector - The string which represents the desired selection
 * @param {HTMLElement} parent - Optional: the parent on which the selection is made (default is document)
 * @returns HTMLElement | null
 * 
 */
function qs(selector, parent = document) {
    if ((!selector) || (!parent)) {
        return null;
    }
    return /** @type {HTMLElement} */ (parent.querySelector(selector));
}

/**
 * This function is meant to help find the nearest parent of an element of a certain type. It is limited to the tag name, meaning you can't use the full querySelector options. If the specific element type can't be found as a parent of the parameter element, null will be returned.
 * 
 * @param {HTMLElement} el - The child element
 * @param {string} parentTagName - The tag name of the parent desired, for exmaple "div"
 * @returns HTMLElement | null
 * 
 */
function findNearestParentOfType(el, parentTagName) {
    if ((!el) || (!parentTagName)) {
        return null;
    }
    if ((!el.parentElement)) {
        return null;
    }

    parentTagName = parentTagName.toLowerCase();
    let reachedRootNode = false;

    while (el.tagName.toLowerCase() !== parentTagName && !reachedRootNode) {
        if (el.tagName.toLowerCase() === "html" || (!el.parentElement)) {
            reachedRootNode = true;
        }
        else {
            el = el.parentElement;
        }
    }

    if (!reachedRootNode) {
        return /** @type {HTMLElement} */ (el);
    }
    return null;
}

/**
 * This function returns the maximum or minimum "value" attribute of all option elements contained within the dropdown. Returns null if there are no options in the dropdown.
 * 
 * @param {HTMLSelectElement} dropdown - The "select" HTML element
 * @param {boolean} maximum - True by default. If set to true, will return the maximum, and the minimum otherwise
 * @returns Number | null
 * 
 */
function getMaximumOrMinimumValueFromDropdown(dropdown, maximum = true) {
    let dropdownOptions = qsa("option", dropdown);
    if (dropdownOptions.length > 0) {
        let dropdownValues = [];
        for (let i = 0; i < dropdownOptions.length; i++) {
            dropdownValues[i] = /** @type {Number} */ ((/** @type {HTMLInputElement} */ (dropdownOptions[i])).value);
        }
        return maximum ? Math.max(...dropdownValues) : Math.min(...dropdownValues);
    }
    return null;
}

/**
 * This function returns the HTML "option" element that is currently selected in the dropdown parameter. It can also return the value of the option directly, based on the second parameter.
 * 
 * @param {HTMLSelectElement} dropdown - The dropdown to get the selected option form
 * @param {boolean} getValue - Whether to get the value attribute of the option or not. False by default
 * @returns HTMLOptionElement | null | string
 * 
 */
function getSelectedOptionFromDropdown(dropdown, getValue = false) {
    if (dropdown) {
        let option = /** @type {HTMLOptionElement} */ (qsa("option", dropdown)[dropdown.selectedIndex]);
        if (getValue) {
            return option.value;
        }
        return option;
    }
    return null;
}

/**
 * This function is a simple API to set session variables on the server. There is a corresponding route in the app which receives a key value pair and sets it accordingly in the session.
 * 
 * @param {string} key - The session key to set
 * @param {string} value - The value to give to the key
 * 
 */
function setSessionVariable(key, value) {
    if (key && value) {
        fetch(`/Session/SetValue?key=${key}&value=${value}`);
    }
}

/**
 * This function determines if an element can be scrolled (has a scrollbar).
 * 
 * @param {HTMLElement} el 
 * @returns boolean
 * 
 */
function canElementBeScrolled(el) {
    if (el) {
        return el.scrollWidth > el.clientWidth || el.scrollHeight > el.clientHeight;
    }
    return false;
}

/**
 * This function trims, removes all tabs and removes all blank spaces that are longer than one character in the string, and returns it. It also removes line breaks by default, but that can be avoided.
 * 
 * @param {string} str - The string to modify
 * @param {boolean} removeLineBreaks - Whether the function should remove all line breaks or not. True by default
 * @returns string
 */
function removeMultipleWhiteSpace(str, removeLineBreaks = true) {
    str = str.trim();
    str = str.replace(/[\t]/g, "");
    if (removeLineBreaks) {
        str = str.replace(/[\n\r]/g, "");
    }
    while (str.includes("  ")) {
        str = str.replace(/  /, " ");
    }
    return str;
}

// Utility functions ^^^^^ -----------------------------------------------------------------------------------------------------------------

// Misc. functions VVVVV -------------------------------------------------------------------------------------------------------------------

/**
 * Actions in forms which will cause the same page to be displayed can cause this function to be called which temporarily stores the current scroll offset of the window, which be applied once the page reloads (look at the checkIfWindowShouldBeScrolled() function). In order for the page scroll to be stored, the HTML element which causes the page to be reloaded (for example, the button to save changes after adding a competency in the add/edit position page) must have the css class of "resetWindowHeight".
 */
function storeCurrentScrollPosition() {
    localStorage.setItem(localStorageScrollStr, window.scrollY.toString());
}

/**
 * This function gets called when the page loads and when the window is resized. It makes sure that on index pages, if there are buttons on the right side of the screen (buttons that switch between competency types for example), they stay aligned with the end of the table, based on if it can scroll or not.
 */
function checkIfTableCanBeScrolled() {
    let btns = qsa(".index-right-button");
    let saveFileIcon = qs(".index-save-file-icon");
    let locateBtn = qs(".right-button-locate");
    let windowCanScroll = canElementBeScrolled(tableContainer);
    if (btns.length > 0) {
        if (!windowCanScroll) {
            for (let i = 0; i < btns.length; i++) {
                btns[i].classList.remove("index-right-button");
                btns[i].classList.add("index-right-button-no-scroll");
            }
            if (saveFileIcon) {
                saveFileIcon.style.right = "-6px";
            }
        }
        else {
            for (let i = 0; i < btns.length; i++) {
                btns[i].classList.add("index-right-button");
                btns[i].classList.remove("index-right-button-no-scroll");
            }
            if (saveFileIcon) {
                saveFileIcon.style.right = "3px";
            }
        }
    }
    if (locateBtn) {
        if (windowCanScroll) {
            locateBtn.classList.remove("no-margin-right");
            locateBtn.style.marginRight = "8px";
        }
        else {
            locateBtn.style.marginRight = "";
            locateBtn.classList.add("no-margin-right");
        }
    }
}

/**
 * This function updates and returns the string that represents the "formaction" attribute of an element whenever a certificate's selected description is changed on position create/edit, or whenever a competency level is modified.
 * 
 * @param {string} formActionStr - The string that correponds to the "formaction" attribute of the element being updated
 * @param {string} portionToUpdate - This string represents the portion of the formaction string that is of concern, for example, "addedcertificateids"
 * @param {Number} elementId - The database id of the element in the portion to update to be updated. For example, if the element being updated was a competency, this parameter would be the id of the competency
 * @param {Number} newId - The value to apply to that specific element. This won't change the id, but the value of the item associated with that id. For example, for competencies, this is the value of the new level of the competency. For certificates, this is the id of the new certificate description
 * @returns string | null
 * 
 */
function updateFormActionString(formActionStr, portionToUpdate, elementId, newId) {
    try {
        let itemsIdsStr = formActionStr.substring((formActionStr.indexOf(portionToUpdate) + portionToUpdate.length + 1),
            (formActionStr.indexOf("-&", (formActionStr.indexOf(portionToUpdate) + 1))));

        let endIndex = itemsIdsStr.indexOf("-", (itemsIdsStr.indexOf(elementId.toString().concat(ENCODED_AMPERSAND)))) < 0 ? itemsIdsStr.length :
            itemsIdsStr.indexOf("-", (itemsIdsStr.indexOf(elementId.toString().concat(ENCODED_AMPERSAND))));

        let itemToUpdateStr = itemsIdsStr.substring((itemsIdsStr.indexOf(elementId.toString().concat(ENCODED_AMPERSAND))),
            endIndex);

        let updatedStr = itemToUpdateStr.substring(0, itemToUpdateStr.indexOf(ENCODED_AMPERSAND) + ENCODED_AMPERSAND.length).concat(newId.toString());

        let formActionStrArr = formActionStr.split('');
        formActionStrArr.splice(formActionStr.indexOf(itemToUpdateStr), itemToUpdateStr.length, updatedStr);
        let updatedFormActionStr = formActionStrArr.join('');

        return updatedFormActionStr;
    }
    catch {
        return null;
    }
}

/**
 * This function is used to retrieve the td elements that are not empty in the table column specified by the parameter. This happens when sorting/reversing the column on the locate similar position results page. There is logic in place to ensure that only the elements that are not empty are retrieved, since the table in question may not have an equal number of elements per row, so some cells may be empty.
 * 
 * @param {Number} columnIndex - The index of the column from which the table cells should be retrieved
 * @param {HTMLElement[]} tableRows - The HTML "tr" elements of the main table
 * @returns HTMLElement[]
 * 
 */
function getNonEmptyTableCellsInColumn(columnIndex, tableRows) {
    let allRowElements = [];
    for (let i = 0; i < tableRows.length; i++) { // loop through the table rows
        let elements = qsa("td", tableRows[i]);
        if (elements.length > 0) {
            let element = elements[columnIndex];
            if (element) {
                for (let j = 0; j < element.childElementCount; j++) { // loop through the children of the cell in the column specified
                    if (elements[columnIndex].children[j].nodeName) {
                        // the function looks specifically for non-empty links within the table cells of the column specified
                        if (elements[columnIndex].children[j].nodeName.toLowerCase() === "a") {
                            if (elements[columnIndex].children[j].textContent.trim() !== "") {
                                allRowElements[i] = /** @type {HTMLElement} */ (elements[columnIndex].cloneNode(true));
                            }
                        }
                    }
                }
            }
        }
    }
    return allRowElements;
}

// Misc. functions ^^^^^ -------------------------------------------------------------------------------------------------------------------

// Competency level functions VVVVV --------------------------------------------------------------------------------------------------------

/**
 * This function is used on tables headers where the elements in the next rows are expandable, for instance in the add/edit/details position page, where you can expand competencies and certificates. This function toggles every expandable element in that table, or in the case of the details page, where there are multiple subsections to the same large table, it expands every element until it meets the next "header" row of the table.
 * 
 * @param {HTMLElement} el - The element whose siblings contained in the next table rows are to be expanded (usually a table header)
 * 
 */
function toggleExpandableElementsInNextRows(el) {
    let columnAffected = 1;
    let nearestParentRow = findNearestParentOfType(el, "tr");
    let nearestParentTable = findNearestParentOfType(el, "table");

    if (nearestParentRow && nearestParentTable) {
        let rowsToExpand = [];
        let allTableRows = qsa("tr", nearestParentTable);
        let startingRowIndex = -1, endingRowIndex = -1;

        // basically, the goal is to find all rows in between header rows. These will correspond to the rows which contain expandable items. For example, in the position details page, each competency type has a header row, and then each competency of that type added to the position has its own row. These are the rows we are trying to identify here in the next loops

        for (let i = 0; i < allTableRows.length && startingRowIndex === -1; i++) {
            let currentRow = allTableRows[i];
            if (currentRow.contains(el)) {
                startingRowIndex = i;
            }
        }

        for (let i = startingRowIndex + 1; i < allTableRows.length && endingRowIndex === -1; i++) {
            let currentRow = allTableRows[i];
            let nodesInRow = qsa("*", currentRow);
            for (let j = 0; j < nodesInRow.length; j++) {
                if (nodesInRow[j].tagName.toLowerCase() === "th") {
                    endingRowIndex = i;
                }
            }
            if (i === allTableRows.length - 1 && endingRowIndex === -1) {
                endingRowIndex = allTableRows.length;
            }
        }

        rowsToExpand = allTableRows.slice(startingRowIndex + 1, endingRowIndex);

        if (qsa(".collapsing", nearestParentTable).length === 0) { // this is to make sure that nothing happens if elements are currently being expanded/closed, otherwise the state might be slightly off

            if (qsa(".accordion", rowsToExpand[0]).length > 0) { // this is just to determine if there is something expandable in the rows, if not, there's no point in trying to expand the elements

                if (el.classList.contains("second-column")) { // this is for the competency rows/tables, where you can expand both the competency names or the levels associated to them
                    columnAffected = 2;
                }

                let expandingItems = el.classList.contains("closed");
                if (expandingItems) {
                    el.classList.remove("closed");
                    el.classList.add("opened");
                }
                else {
                    el.classList.add("closed");
                    el.classList.remove("opened");
                }

                // in the case of the add/edit position page, all expandable elements will be within the same table row. However, each item will be within a separate div.row. So, if we only have one row, and that row has at least one div.row, instead of looping through multiple table rows, we will now loop through those div.row. The rest of the code behaves the same
                if (qsa("td div.row", rowsToExpand[0]).length > 0 && rowsToExpand.length === 1) {
                    rowsToExpand = qsa("td div.row", rowsToExpand[0]);
                }

                for (let i = 0; i < rowsToExpand.length; i++) {
                    let btnsInRow = qsa("button.btn", rowsToExpand[i]);

                    for (let i = 0; i < btnsInRow.length; i++) {
                        if ((i + 1) === columnAffected) {
                            if ((expandingItems && btnsInRow[i].getAttribute("aria-expanded") === "false") || (!expandingItems && btnsInRow[i].getAttribute("aria-expanded") === "true"))
                                btnsInRow[i].click();
                        }
                    }
                }
            }
        }
    }
}

/**
 * This function gets called whenever a dropdown to change a competency's level gets updated, either by the dropdown itself, or by the + or - buttons. It ensures that if the dropdown is at its maximum or minimum value, the corresponding button gets disabled (and re-enabled if the value changes again and is no longer at an extreme).
 * 
 * @param {HTMLSelectElement} dropdown - The dropdown which had its value updated
 * 
 */
function checkCompetencyLevelButtonsState(dropdown) {
    if (dropdown) {
        let minusButton = dropdown.previousElementSibling;
        let plusButton = dropdown.nextElementSibling;

        let currentValue = Number(dropdown.value);
        let maxValue = getMaximumOrMinimumValueFromDropdown(dropdown);
        let minValue = getMaximumOrMinimumValueFromDropdown(dropdown, false);

        minusButton.classList.remove("disabled");
        plusButton.classList.remove("disabled");

        if (currentValue === minValue) {
            minusButton.classList.add("disabled");
        }
        if (currentValue === maxValue) {
            plusButton.classList.add("disabled");
        }
    }
}

/**
 * This function gets called whenever the user modifies the level of a competency in edit/create position, either by using the buttons, or by using the dropdown. It will adjust the competency level description to match that of the new level. You can see this description by expanding the "LEVEL / NIVEAU" column of the competency tables. (Note, the data for the competency level descriptions is simply hidden in the page, and it gets queried from there).
 * 
 * @param {HTMLSelectElement} dropdown - The dropdown representing the competency level which had its value modified
 * 
 */
function setCompetencyLevelDescription(dropdown) {
    if (dropdown) {
        let div = findNearestParentOfType(dropdown, "div");
        let value = dropdown.value;
        let textValue = (/** @type {HTMLOptionElement} */ (getSelectedOptionFromDropdown(dropdown))).textContent;
        if (div) {
            let englishLeveDesc = qs(".engLevelDesc", div);
            let frenchLevelDesc = qs(".freLevelDesc", div);
            if (englishLeveDesc && frenchLevelDesc) {
                let levelDescriptions = qsa(".competencyLevelDesc");
                if (levelDescriptions) {
                    let newEnglishLevelDesc = qs(".eng", levelDescriptions[value - 1]).textContent;
                    let newFrenchLevelDesc = qs(".fre", levelDescriptions[value - 1]).textContent;
                    if (newFrenchLevelDesc && newEnglishLevelDesc) {
                        englishLeveDesc.textContent = newEnglishLevelDesc;
                        frenchLevelDesc.textContent = newFrenchLevelDesc;
                    }
                }
            }
            let compLevelReqDescEng = qs(".compLevelReqDescEng", div);
            let compLevelReqDescFre = qs(".compLevelReqDescFre", div);
            if (compLevelReqDescEng && compLevelReqDescFre) {
                let englishCompLevelDescs = qsa(".compDescEng", div);
                let frenchCompLevelDescs = qsa(".compDescFre", div);
                if (englishCompLevelDescs && frenchCompLevelDescs) {
                    let newCompLevelReqDescEng = englishCompLevelDescs[textValue - 1].textContent;
                    let newCompLevelReqDescFre = frenchCompLevelDescs[textValue - 1].textContent;
                    if (newCompLevelReqDescEng && newCompLevelReqDescFre) {
                        compLevelReqDescEng.textContent = newCompLevelReqDescEng;
                        compLevelReqDescFre.textContent = newCompLevelReqDescFre;
                    }
                }
            }
        }
    }
}

/**
 * This function replaces all formaction attributes on the page (add/edit position) whenever a competency level is changed. In doing so, users are able to change the level of a competency without having to remove and add the competency again. If the function gets called by pressing the + or - button, this function also replaces the associated dropdown with the updated number.
 * 
 * @param {HTMLElement} el - The HTMLElement which caused the function to be called, either a + or - button, or a competency level dropdown
 * @param {Number} newNum - The new competency level. It will be set if this function gets called by selecting the dropdown value
 * 
 */
function changeCompetencyLevelValue(el, newNum = null) {
    let newDropdownValue;
    let valueChanged;
    let dropdown;

    if (newNum) {
        valueChanged = true;
        newDropdownValue = newNum;
        dropdown = el;
    }
    else {
        let increment = true;

        if (el.classList.contains("minus-icon")) {
            dropdown = el.nextElementSibling;
            increment = false;
        }
        else {
            dropdown = el.previousElementSibling;
        }
        dropdown = /** @type {HTMLSelectElement} */ (dropdown);

        let originalDropdownValue = Number(dropdown.value);
        let maxDropdownValue = getMaximumOrMinimumValueFromDropdown(dropdown);
        let minDropdownValue = getMaximumOrMinimumValueFromDropdown(dropdown, false);

        if (increment && originalDropdownValue < maxDropdownValue) {
            dropdown.value = originalDropdownValue + 1;
        }
        if (!increment && originalDropdownValue > minDropdownValue) {
            dropdown.value = originalDropdownValue - 1;
        }

        newDropdownValue = Number(dropdown.value);
        valueChanged = (originalDropdownValue !== newDropdownValue);
    }

    if (valueChanged) {
        checkCompetencyLevelButtonsState(dropdown);
        setCompetencyLevelDescription(dropdown);
        let formActionElements = qsa(`[formaction]`);
        let shortCompetencyStr = dropdown.id.substring(0, dropdown.id.indexOf("-"));
        let fullCompetencyStr;
        let compId = Number(dropdown.id.substring(dropdown.id.indexOf("-") + 1));

        switch (shortCompetencyStr) {
            case "know":
                fullCompetencyStr = "addedknowledgecompetencyids";
                break;
            case "tech":
                fullCompetencyStr = "addedtechnicalcompetencyids";
                break;
            case "beha":
                fullCompetencyStr = "addedbehaviouralcompetencyids";
                break;
            case "exec":
                fullCompetencyStr = "addedexecutivecompetencyids";
                break;
        }
        fullCompetencyStr = /** @type {String} */ (fullCompetencyStr);

        for (let i = 0; i < formActionElements.length; i++) {
            formActionElements[i].setAttribute("formaction", updateFormActionString(formActionElements[i].getAttribute("formaction"), fullCompetencyStr, compId, newDropdownValue));
        }
    }
}

/**
 * This function gets called when the user double clicks anywhere on the page, but it only does something if they clicked on a competency that can be expanded (on the edit/create position page). If they clicked on such a competency, this function will toggle expanding/collapsing that competency.
 * 
 * @param {HTMLElement} el - The element that was clicked
 * 
 */
function attemptToExpandCompetency(el) {
    if (el) {
        if (qs(".compLevelDescContainer")) {
            let parentDiv = null;
            let currentEl = el;
            if (currentEl.classList) {
                if (!currentEl.classList.contains("plus-minus-icon")) { // the element should not be toggled if you double-clicked on the + or - buttons
                    while (!parentDiv) {
                        if (currentEl.classList) {
                            if (currentEl.classList.contains("compLevelDescContainer")) {
                                parentDiv = currentEl;
                            }
                        }
                        if (!parentDiv) {
                            if (currentEl.parentElement) {
                                currentEl = currentEl.parentElement;
                            }
                            else {
                                break;
                            }
                        }
                    }
                }
            }

            if (parentDiv) {
                qs(".btn.dontShow", parentDiv).click();
            }
        }
    }
}

// Competency level functions ^^^^^ --------------------------------------------------------------------------------------------------------

// Page interaction functions VVVVV --------------------------------------------------------------------------------------------------------

/**
 * This function makes it so whenever you click on the "All Regions" checkbox on the add/edit position page, all other region checkboxes' state will match the one of the "All Regions" one. This allows you to click once to select all regions at once (and unselect them all at once as well).
 * 
 * @param {HTMLInputElement} masterCheckbox 
 * @param {string} checkboxGroupName
 * 
 */
function toggleAllCheckboxesInGroup(masterCheckbox, checkboxGroupName) {
    if (masterCheckbox && checkboxGroupName) {
        let otherCheckboxes = qsa(`input[name=${checkboxGroupName}][type="checkbox"]`);

        if (otherCheckboxes.length > 0) {
            for (let i = 0; i < otherCheckboxes.length; i++) {
                (/** @type {HTMLInputElement} */ (otherCheckboxes[i])).checked = masterCheckbox.checked;
            }
        }
    }
}

/**
 * This function is used on basically all Index pages, where there is a long list of elements to display. It handles setting the height of the element which contains the table and that can be scrolled through to make sure it takes up as much height as it can on screen without hiding anything. The minimum height for it is 300px.
 * 
 * @param {boolean} setHeightInSession - Whether or not the new table container height should be set in the session
 * 
 */
function setTableContainerMaxHeight(setHeightInSession = false) {
    footer = /** @type {HTMLElement} */ (footer);
    tableContainer = /** @type {HTMLDivElement} */ (tableContainer);
    windowHeight = /** @type {number} */ (windowHeight);

    if (tableContainer) {
        let newHeight = windowHeight - footer.getBoundingClientRect().height - tableContainer.getBoundingClientRect().y - MARGIN_BETWEEN_FOOTER_AND_TABLE;
        if (newHeight < 300) {
            newHeight = 300;
        }
        tableContainer.style.maxHeight = `${newHeight}px`;
        tableContainer.style.minHeight = `${newHeight}px`;

        // this code handles centering vertically the text that appears when a position could not be found in a percentage column in the locate similar positions results page
        let noResultColumns = qsa(".no-matching-positions-at-percent");
        if (noResultColumns.length > 0) {
            let thead = qs("thead", tableContainer);
            if (thead) {
                for (let i = 0; i < noResultColumns.length; i++) {
                    let span = qs("span", noResultColumns[i]);
                    let top = ((tableContainer.getBoundingClientRect().height - span.getBoundingClientRect().height - thead.getBoundingClientRect().height) / 2) + thead.getBoundingClientRect().height;
                    span.style.top = `${top}px`;
                }
            }
        }

        // this code resizes the links to the left of the page on the All Position Details page (if applicable)
        let listGroup = qs("#APD-list-group");
        if (listGroup) {
            listGroup.style.maxHeight = `${newHeight}px`;
            listGroup.style.minHeight = `${newHeight}px`;

            let availableWidth = tableContainer.getBoundingClientRect().x;
            const emptySpace = availableWidth / 10; // there should be 10% empty space
            let newWidth = availableWidth - emptySpace;

            listGroup.style.width = `${newWidth}px`;
            listGroup.style.maxWidth = `${newWidth}px`;
            listGroup.style.left = `${(newWidth + (emptySpace / 2)) * -1}px`;
        }

        if (setHeightInSession) {
            // the reason the tableContainer height can be stored is so that when you switch between pages, the tableContainer starts off with the previous height it had, which means it may not have to be resized at all on the new page, to remove some visual flicker
            setSessionVariable("lastTableContainerHeight", newHeight.toString());
        }
    }
}

/**
 * This function gets called when the user changes a certificate that has been added to a position's description, by selecting it in the dropdown. Similarly to the changeCompetencyLevelValue() function, this function changes the formaction attribute of all elements in the page that have it to update the certificate description id of the certificate that was updated. This function also handles hiding/showing/updating the link that leads to the certificate description (it becomes hidden if the description selected is the empty one).
 * 
 * @param {HTMLSelectElement} dropdown - The certificate description dropdown that was modified
 * 
 */
function changeCertificateDescription(dropdown) {
    let selectedCertDescId = Number(dropdown.value);
    let certId = Number(dropdown.id.substring(dropdown.id.lastIndexOf("-") + 1));
    let selectedEmptyDesc = false;
    if (selectedCertDescId === EMPTY_CERT_DESC_ID) {
        selectedEmptyDesc = true;
    }

    let parentDiv = findNearestParentOfType(dropdown, "div");
    let verticalBar = qs(".vertical-bar-cert-desc", parentDiv);
    let certDescLink = qs(".cert-desc-link", parentDiv);

    if (selectedEmptyDesc) {
        certDescLink.classList.add("dontShow");
        verticalBar.classList.add("dontShow");
        dropdown.classList.add("bold");
    }
    else {
        certDescLink.classList.remove("dontShow");
        verticalBar.classList.remove("dontShow");
        dropdown.classList.remove("bold");
    }

    certDescLink.setAttribute("href", `${certDescLink.getAttribute("href").substring(0, certDescLink.getAttribute("href").indexOf("=") + 1)}${selectedCertDescId}`);

    let formActionElements = qsa(`[formaction]`);
    for (let i = 0; i < formActionElements.length; i++) {
        formActionElements[i].setAttribute("formaction", updateFormActionString(formActionElements[i].getAttribute("formaction"), "addedcertificateids", certId, selectedCertDescId));
    }
}

/**
 * This function is used on tables headers where the elements in the next rows are expandable, for instance in the add/edit/details position page, where you can expand competencies and certificates. This function toggles every expandable element in that table, or in the case of the details page, where there are multiple subsections to the same large table, it expands every element until it meets the next "header" row of the table.
 * 
 * @param {HTMLElement} el - The element whose siblings contained in the next table rows are to be expanded (usually a table header)
 * 
 */
function toggleExpandableElementsInNextRows(el) {
    let columnAffected = 1;
    let nearestParentRow = findNearestParentOfType(el, "tr");
    let nearestParentTable = findNearestParentOfType(el, "table");

    if (nearestParentRow && nearestParentTable) {
        let rowsToExpand = [];
        let allTableRows = qsa("tr", nearestParentTable);
        let startingRowIndex = -1, endingRowIndex = -1;

        // basically, the goal is to find all rows in between header rows. This will correspond to the rows which contain expandable items. For example, in the position details page, competencies have a header row, and then one row per competency. These are the rows we are trying to identify here in the next loops

        for (let i = 0; i < allTableRows.length && startingRowIndex === -1; i++) {
            let currentRow = allTableRows[i];
            if (currentRow.contains(el)) {
                startingRowIndex = i;
            }
        }

        for (let i = startingRowIndex + 1; i < allTableRows.length && endingRowIndex === -1; i++) {
            let currentRow = allTableRows[i];
            let nodesInRow = qsa("*", currentRow);
            for (let j = 0; j < nodesInRow.length; j++) {
                if (nodesInRow[j].tagName.toLowerCase() === "th") {
                    endingRowIndex = i;
                }
            }
            if (i === allTableRows.length - 1 && endingRowIndex === -1) {
                endingRowIndex = allTableRows.length;
            }
        }

        rowsToExpand = allTableRows.slice(startingRowIndex + 1, endingRowIndex);

        if (qsa(".collapsing", nearestParentTable).length === 0) { // this is to make sure that nothing happens if elements are currently being expanded/closed, otherwise the state might be slightly off

            if (qsa(".accordion", rowsToExpand[0]).length > 0) { // this is just to determine if there is something expandable in the rows, if not, there's no point in trying to expand the elements

                if (el.classList.contains("second-column")) { // this is for the competency rows/tables, where you can expand both the competency names or the levels associated to them
                    columnAffected = 2;
                }

                let expandingItems = el.classList.contains("closed");
                if (expandingItems) {
                    el.classList.remove("closed");
                    el.classList.add("opened");
                }
                else {
                    el.classList.add("closed");
                    el.classList.remove("opened");
                }

                // in the case of the add/edit position page, all expandable elements will be within the same table row. However, each item will be within a separate div.row. So, if we only have one row, and that row has at least one div.row, instead of looping through multiple table rows, we will now loop through those div.row. The rest of the code behaves the same
                if (qsa("td div.row", rowsToExpand[0]).length > 0 && rowsToExpand.length === 1) {
                    rowsToExpand = qsa("td div.row", rowsToExpand[0]);
                }

                for (let i = 0; i < rowsToExpand.length; i++) {
                    let btnsInRow = qsa("button.btn", rowsToExpand[i]);

                    for (let i = 0; i < btnsInRow.length; i++) {
                        if ((i + 1) === columnAffected) {
                            if ((expandingItems && btnsInRow[i].getAttribute("aria-expanded") === "false") || (!expandingItems && btnsInRow[i].getAttribute("aria-expanded") === "true"))
                                btnsInRow[i].click();
                        }
                    }
                }
            }
        }
    }
}

/**
 * This function gets called when the user double clicks anywhere on the page, but it only does something if they clicked on a competency level that can be expanded (on the edit/create position page). If they clicked on such a competency, this function will toggle expanding/collapsing that competency.
 * 
 * @param {HTMLElement} el - The element that was double clicked
 * 
 */
function attemptToExpandCompetency(el) {
    if (el) {
        let parentDiv = null;
        let currentEl = el;
        if (currentEl.classList) {
            if (!currentEl.classList.contains("plus-minus-icon")) { // the element should not be toggled if you double-clicked on the + or - buttons
                while (!parentDiv) {
                    if (currentEl.classList) {
                        if (currentEl.classList.contains("compLevelDescContainer")) {
                            parentDiv = currentEl;
                        }
                    }
                    if (!parentDiv) {
                        if (currentEl.parentElement) {
                            currentEl = currentEl.parentElement;
                        }
                        else {
                            break;
                        }
                    }
                }
            }
        }

        if (parentDiv) {
            qs(".btn.dontShow", parentDiv).click();
        }
    }
}

/**
 * This function sorts the tables in the index pages based on the column header that was clicked. The sort can be reversed by clicking the same column again. It also can sort the columns that display the number of matching positions per percentage, if the second parameter is set to true.
 * 
 * @param {HTMLElement} el - The column header that was clicked (the element that contains the text that was clicked, likely a "bold" tag)
 * @param {boolean} sortPercents - Whether the table being sorted is displaying the number of matching positions per percentage (only applicable in similar positions index page)
 * @param {boolean} maintainSortDirection - Whether the selected column should keep its previous sort direction (it will not be flipped if set to true). False by default
 * @param {string} attributeToSortOn - If this parameter is provided, the sort will be performed not on the textContent of the cells, but instead on the value of the attribute (if the attribute does not exist or is empty, the textContent will be used instead)
 * 
 */
function sortColumn(el, sortPercents = false, maintainSortDirection = false, attributeToSortOn = null) {
    if (el) {
        let table = findNearestParentOfType(el, "table");
        let rows = qsa("tbody tr", table);
        if (rows.length > 0) {
            let allColumnHeaders = sortPercents ? qsa(".sort-column-percents", table) : qsa(".sort-column", table);
            let columnToSortIndex = -1;

            let flipOperator = el.classList.contains("sorted") ? -1 : 1;

            if (maintainSortDirection) {
                flipOperator *= -1;
            }

            for (let i = 0; i < allColumnHeaders.length; i++) {
                if (allColumnHeaders[i] === el) {
                    columnToSortIndex = i;
                }
                allColumnHeaders[i].classList.remove("sorted");
                allColumnHeaders[i].classList.remove("reverse-sorted");
            }

            let orderedRows = rows.sort((a, b) => {
                let cellsA = sortPercents ? qsa(".sort-percents", a) : qsa("td", a);
                let cellsB = sortPercents ? qsa(".sort-percents", b) : qsa("td", b);
                let specificCellA = cellsA[columnToSortIndex];
                let specificCellB = cellsB[columnToSortIndex];

                // in the All Position Details page, the cells may have the class of empty. If they do, they should sort last, which is why this special case is featured here
                if (specificCellA.classList.contains("empty") || specificCellB.classList.contains("empty")) {
                    let emptyA = specificCellA.classList.contains("empty");
                    let emptyB = specificCellA.classList.contains("empty");

                    if (emptyA && !emptyB) {
                        return -1;
                    }
                    if (!emptyA && emptyB) {
                        return 1;
                    }
                }

                let textContentA;
                let textContentB;
                let sortingOnAttribute = false;

                if (attributeToSortOn) {
                    if (specificCellA.getAttribute(attributeToSortOn) && specificCellB.getAttribute(attributeToSortOn)) {
                        sortingOnAttribute = true;
                    }
                }

                if (sortingOnAttribute) {
                    textContentA = specificCellA.getAttribute(attributeToSortOn);
                    textContentB = specificCellB.getAttribute(attributeToSortOn);
                }
                else {
                    textContentA = specificCellA.textContent.toLocaleLowerCase();
                    textContentB = specificCellB.textContent.toLocaleLowerCase();
                }

                let comparingNumbers = false;

                let numberA, numberB;
                if (sortPercents) {
                    numberA = Number(textContentA);
                    numberB = Number(textContentB);
                    if (!isNaN(numberA) && !isNaN(numberB)) {
                        comparingNumbers = true;
                    }
                }

                if (!comparingNumbers) {
                    return textContentA.localeCompare(textContentB) * flipOperator;
                }
                else {
                    if (numberA < numberB) {
                        return flipOperator * -1;
                    }
                    else if (numberA > numberB) {
                        return flipOperator * 1;
                    }
                    return 0;
                }
            });
            let rowContainer = rows[0].parentElement;
            rowContainer.innerHTML = "";

            for (let i = 0; i < orderedRows.length; i++) {
                rowContainer.appendChild(orderedRows[i]);
            }

            if (flipOperator === 1) {
                el.classList.add("sorted");
            }
            else {
                el.classList.add("reverse-sorted");
            }
        }
    }
    toggleLoadingSymbol(false);
}

/**
 * This function sorts every column individually in the table displaying results for located similar positions. It is only called when switching the language of the job titles displayed, in order to keep the jobs sorted properly.
 */
function sortEveryColumn() {
    let tableHeaders = qsa("th b", tableContainer);
    let numColumns = tableHeaders.length;
    let rows = qsa("tbody tr", tableContainer);
    for (let i = 0; i < numColumns; i++) {
        if (tableHeaders[i].classList.contains("flip-column")) { // this means this table column contains elements
            let elementsToSort = getNonEmptyTableCellsInColumn(i, rows);
            let flipOperator = tableHeaders[i].classList.contains("sorted") ? 1 : -1;
            let sortedElements = elementsToSort.sort((a, b) => {
                let textA = qs("a:not(.dontShow)", a).textContent.toLowerCase();
                let textB = qs("a:not(.dontShow)", b).textContent.toLowerCase();

                return textA.localeCompare(textB) * flipOperator;
            });

            for (let j = 0; j < sortedElements.length; j++) {
                if (sortedElements[j].firstElementChild.classList.contains("bold")) {
                    let el = sortedElements[j];
                    sortedElements.splice(j, 1);
                    if (flipOperator === 1) {
                        sortedElements.unshift(el);
                    }
                    else {
                        sortedElements.push(el);
                    }
                }
            }

            for (let j = 0; j < elementsToSort.length; j++) {
                let elements = qsa("td", rows[j]);
                elements[i].replaceWith(sortedElements[j]);
            }
        }
    }
}

/**
 * This function reverses the elements in the table column. It is only used by the results table for located similar positions.
 * 
 * @param {HTMLElement} el - The column header that was clicked
 * 
 */
function flipColumn(el) {
    if (el) {
        let table = findNearestParentOfType(el, "table");
        let rows = qsa("tbody tr", table);
        let allColumnHeaders = qsa("th b");
        let columnToFlipIndex = -1;

        let originalSortDirection = el.classList.contains("sorted") ? 1 : -1;

        for (let i = 0; i < allColumnHeaders.length; i++) {
            if (allColumnHeaders[i] === el) {
                columnToFlipIndex = i;
                allColumnHeaders[i].classList.remove("sorted");
                allColumnHeaders[i].classList.remove("reverse-sorted");
            }
        }

        let allRowElements = getNonEmptyTableCellsInColumn(columnToFlipIndex, rows);

        for (let i = 0; i < allRowElements.length; i++) {
            let elements = qsa("td", rows[i]);
            elements[columnToFlipIndex].replaceWith(allRowElements[allRowElements.length - 1 - i]);
        }

        if (originalSortDirection === 1) {
            el.classList.add("reverse-sorted");
        }
        else {
            el.classList.add("sorted");
        }
    }
}

/**
 * This function gets called if users click on a link that says "Overwrite" when copying similar positions over. It sets up the link used by the modal window that makes users aware that they may overwrite data by copying over the similar positions. Since there is only one modal window and that it may be used by all "Overwrite" links, this function just makes sure that the modal window will have a link to the appropriate position.
 * 
 * @param {HTMLElement} el - The link that was clicked
 * 
 */
function prepareOverwriteSimilarModalLink(el) {
    qs("#btn-modal-overwrite-similar").setAttribute("href", `/Similar/Create?id=${el.getAttribute("value")}&copyid=${qs("#position-copied-id").textContent}`);
}

/**
 * This function gets called whenever a link is clicked on the located position results page, or in the navigation. It helps users keep track of which links they have clicked by making them a different colour. In the navigation, it just makes sure the link has the proper colour when loading the next page.
 * 
 * @param {HTMLElement} el - The link that was clicked
 * @param {boolean} targetSibling - Whether or not the sibling link should be made visited as well. It is true when the link comes from the locate positions page
 * @param {boolean} ctrlHeld - Whether or not the CTRL key was being held when the click happened
 * 
 */
function makeLinkVisited(el, targetSibling = true, ctrlHeld = false) {
    if (!ctrlHeld || targetSibling) {
        if (el.classList) {
            if (!el.classList.contains("visited")) {
                if (!qs(".nav-link.visited")) {
                    el.classList.add("visited");
                    if (targetSibling) {
                        let sibling = el.nextElementSibling ? el.nextElementSibling : el.previousElementSibling;
                        sibling.classList.add("visited");
                    }
                }
            }
        }
    }
    console.log("yo")
    if (ctrlHeld) {
        // if the user clicked on a navigation link while holding ctrl, it means the link opened in a new tab. This blur() call is to ensure that the animated underline that appears below a navigation link doesn't stay there, because the element was focused
        console.log("hi")
        el.blur();
    }
}

/**
 * This function is used on the located similar position results screen to alternate between displaying the French and English titles of positions. It is called by clicking the radio buttons associated to the languages. All this does is change CSS classes to hide/show elements.
 * 
 * @param {HTMLInputElement} el - The radio button that was clicked
 * 
 */
function swapJobTitleLanguage(el) {
    let changingToEnglish = el.value.toLowerCase() === "eng";
    let englishElements = qsa("a[lang='en']");
    let frenchElements = qsa("a[lang='fr']");
    if (changingToEnglish) {
        qs("#jobTitleEng").classList.remove("dontShow");
        qs("#jobTitleFre").classList.add("dontShow");
    }
    else {
        qs("#jobTitleEng").classList.add("dontShow");
        qs("#jobTitleFre").classList.remove("dontShow");
    }
    for (let i = 0; i < englishElements.length; i++) {
        if (changingToEnglish) {
            englishElements[i].classList.remove("dontShow");
            frenchElements[i].classList.add("dontShow");
        }
        else {
            englishElements[i].classList.add("dontShow");
            frenchElements[i].classList.remove("dontShow");
        }
    }
    setTableContainerMaxHeight();
    sortEveryColumn();
}

/**
 * 
 * This function gets called whenever a form is submited. It ensures that every text field has its contents trimmed with string.trim() before being submitted, to avoid unnecessary whitespace.
 * 
 * @param {HTMLFormElement} el - The form being submitted
 * 
 */
function trimFormFields(el) {
    if (el) {
        let inputs =  /** @type {HTMLInputElement[]} */ (qsa("input[type='text']", el));
        let textareas = /** @type {HTMLInputElement[]} */ (qsa("textarea", el));

        if (inputs.length > 0) {
            for (let i = 0; i < inputs.length; i++) {
                inputs[i].value = inputs[i].value.trim();
            }
        }

        if (textareas.length > 0) {
            for (let i = 0; i < textareas.length; i++) {
                textareas[i].value = textareas[i].value.trim();
            }
        }
    }
}

/**
 * This function gets called when the page loads if there is an element that should be smoothly scrolled into view. This is used for example when locating an item in the application.
 * 
 * @param {HTMLElement} el - The element to scroll into view
 * @param {string} location - Where the element to scroll into view should appear on screen (possible values: start (default), center, end, nearest)
 * @param {boolean} highlightElement - Whether or not the element should be highlighted, false by default
 * @param {boolean} openElement - Whether to click on the element to open it, false by default
 * 
 */
function smoothScrollToElement(el, location = "start", highlightElement = false, openElement = false) {
    if (el) {
        if (openElement) {
            el.click();
        }
        if (highlightElement) {
            el.classList.add("highlighted")
        }
        setTimeout(() => {
            el.scrollIntoView({ behavior: "smooth", block: location, inline: "nearest" });
        }, 100)
    }
}

/**
 * This function gets called whenever the user clicks on the screen. It removes the highlight effect of any elements (if applicable). The highlight would have been added when locating an element.
 */
function removeHighlights() {
    if (qs(".highlighted")) {
        let highlightedEls = qsa(".highlighted");
        for (let i = 0; i < highlightedEls.length; i++) {
            highlightedEls[i].classList.remove("highlighted");
        }
    }
}

/**
 * This function positions a tiny element in the navigation which hides the space below the "Competencies" link, which otherwise has a weird effect when the dropdown options appear on hover.
 */
function positionCompNavHider() {
    let compNavHider = qs("#compNavHider");
    let compNav = qs("#navCompetencies");
    if (compNav && compNavHider) {
        compNavHider.style.left = `${compNav.getBoundingClientRect().x - 1}px`;
        compNavHider.style.width = `${compNav.getBoundingClientRect().width}px`;
    }
}

/**
 * 
 * This function makes it so if you are hovering over the Competencies link in the navigation, it will ensure that the dropdown options will display. This is because of a weird space that otherwise exists between the actual "Competencies" link and the dropdown, where the hover effect wouldn't apply.
 * 
 * @param {MouseEvent} e - The mouseover event
 * 
 */
function checkIfCompetencyDropdownShouldDisplay(e) {
    let navComp = qs("#navCompetencies");
    if (navComp && !qs(".modal.show")) { // the dropdown should not appear if a modal window is currently displayed
        let navCompRect = navComp.getBoundingClientRect();
        if ((e.pageX > navCompRect.x && e.pageX < (navCompRect.x + navCompRect.width)) &&
            (e.pageY < navCompRect.height + 1)) {
            navComp.classList.add("hovered");
        }
        else {
            navComp.classList.remove("hovered");
        }
    }
}

/**
 * This function toggles displaying/hiding the loading indicator of the application. It also allows to manually set the symbol to be displayed or hidden from view. In general, for an element to toggle the loading symbol, it must have the CSS class of "load-link".
 * 
 * @param {boolean} show - If you want to set the symbol to display or not specifically. This parameter is not necessary, since this function is a toggle
 * 
 */
function toggleLoadingSymbol(show = null) {
    let loadingSymbol = qs("#loading-indicator");
    if (loadingSymbol) {
        let showSymbol = true;

        if (show !== null) {
            showSymbol = show;
        }
        else {
            showSymbol = loadingSymbol.classList.contains("dontShow");
        }

        if (showSymbol) {
            loadingSymbol.classList.remove("dontShow");
        }
        else {
            loadingSymbol.classList.add("dontShow");
        }
    }
}

/**
 * This function gets called whenever a modal window is toggled. The function uses attributes of the element parameter to determine whether the modal is being opened or closed, and toggles hiding/displaying certain elements based on that.
 * 
 * @param {HTMLElement} el - The element that has toggled the modal window
 * 
 */
function modalToggled(el) {
    let opening = true;
    if (el.getAttribute("data-dismiss") || el.getAttribute("aria-modal")) {
        if (el.getAttribute("data-dismiss") === "modal" || el.getAttribute("aria-modal") === "true") {
            opening = false;
        }
    }

    let navHider = qs("#navHider");
    let bottomNavHider = qs("#bottomNavHider");
    let compNavHider = qs("#compNavHider");

    // these three elements should be hidden from view when a modal window is on screen, since they have a higher z-index, which means that otherwise they would appear in front of it

    if (navHider && bottomNavHider && compNavHider) {
        if (opening) {
            navHider.classList.add("dontShow");
            bottomNavHider.classList.add("dontShow");
            compNavHider.classList.add("dontShow");
        }
        else {
            setTimeout(() => { // since the modal fades out, they shouldn't re-appear instantly
                navHider.classList.remove("dontShow");
                bottomNavHider.classList.remove("dontShow");
                compNavHider.classList.remove("dontShow");
            }, 500);
        }
    }
}

// Page interaction functions ^^^^^ --------------------------------------------------------------------------------------------------------

// All Position Details (APD) functions VVVVV ----------------------------------------------------------------------------------------------

// The APD functions are the functions used specifically on the All Position Details page. An explanation of how that page works can be found in the code of that page in the project

// Something you may notice in these functions is that whenver there is a call to toggle on the loading symbol, the code that executes after waits 100 milliseconds before doing so. This is to ensure that the loading symbol is on screen before the time-consuming peration occurs, like applying filters or changing the columns displayed

/**
 * This function gets called after all checkboxes are toggled on the All Positions Page. It ensures that at least one checkbox remains checked.
 */
function APDMakeSureOneCheckboxSelected() {
    let checkboxes = (/** @type {HTMLInputElement[]} */ (qsa("[name='APD-columns']")));

    if (checkboxes.length > 0) {
        let oneIsChecked = false;
        for (let i = 0; i < checkboxes.length && !oneIsChecked; i++) {
            if (checkboxes[i].checked) {
                oneIsChecked = true;
            }
        }

        if (!oneIsChecked) {
            checkboxes[0].checked = true;
        }
    }
}

/**
 * This function is used on the All Position Details page when the columns to display change. It handles displaying/hiding the columns accordingly, as well as the navigation links on the side of the page, all based on the checkboxes selected.
 */
function APDChangeDisplayedItem() {
    toggleLoadingSymbol(true);

    setTimeout(() => {
        let checkboxes = (/** @type {HTMLInputElement[]} */ (qsa(`[name="APD-columns"]`)));
        let selectedItems = [];
        for (let i = 0; i < checkboxes.length; i++) {
            if (checkboxes[i].checked) {
                selectedItems.push(checkboxes[i].value);
            }
        }

        // basically, the code loops through all the rows in the table, and only displays the cells that have the corresponding checkbox checked. This is done using CSS classes, since the values of the checkboxes correspond to a CSS class on the cells of the coresponding column

        APDAllTableRows = (/** @type {HTMLTableRowElement[]} */ (APDAllTableRows));
        for (let j = 0; j < APDAllTableRows.length; j++) {
            let apdItems = qsa(".APD-item", APDAllTableRows[j]);
            if (apdItems.length > 0) {
                for (let i = 0; i < apdItems.length; i++) {
                    let matchesOne = false;
                    for (let k = 0; k < selectedItems.length && !matchesOne; k++) {
                        if (apdItems[i].classList.contains(selectedItems[k])) {
                            matchesOne = true;
                        }
                    }
                    if (matchesOne) {
                        apdItems[i].classList.remove("dontShow");
                    }
                    else {
                        apdItems[i].classList.add("dontShow");
                    }
                }
            }
        }

        // displaying/hiding the nav links to the side of the page (still based on the CSS classes)
        let listGroup = qs("#APD-list-group");
        if (selectedItems.length > 1) {
            listGroup.classList.remove("dontShow");
            let listGroupItems = qsa("a", listGroup);
            for (let i = 0; i < listGroupItems.length; i++) {
                let shouldDisplay = false;
                for (let j = 0; j < selectedItems.length && !shouldDisplay; j++) {
                    if (listGroupItems[i].classList.contains(selectedItems[j])) {
                        shouldDisplay = true;
                    }
                }
                if (shouldDisplay) {
                    listGroupItems[i].classList.remove("dontShow");
                }
                else {
                    listGroupItems[i].classList.add("dontShow");
                }
            }
        }
        else {
            listGroup.classList.add("dontShow");
        }

        APDApplyFilters();
        toggleLoadingSymbol(false);
    }, 100);
}

/**
 * This function is used on the All Position Details page. Its job is to add a bit of padding to all table cells that are not those of the first column, when there are more than two columns displayed. This is to ensure that users can only see two columns at a time: the positions, and whichever one is selected. Otherwise, without the extra padding, the next row of cells can be seen for a few pixels.
 */
function APDResizeCells() {
    let headerCells = qsa("th", APDHeaderRow);
    let displayedHeaderCells = headerCells.filter(x => !x.classList.contains("dontShow"));

    tableContainer = (/** @type {HTMLDivElement} */ (tableContainer));
    const tenPercentWidth = tableContainer.getBoundingClientRect().width / 10;
    const secondColumnWidthMultiplier = 7; // the second column takes up 70 percent of the width of the table

    if (displayedHeaderCells.length === 2) {
        tableContainer.scrollLeft = 0;
    } 

    for (let i = 0; i < displayedHeaderCells.length; i++) {
        let currentCell = displayedHeaderCells[i];

        if (i !== 0) {
            currentCell.style.width = `${tenPercentWidth * secondColumnWidthMultiplier}px`;
            currentCell.style.minWidth = `${tenPercentWidth * secondColumnWidthMultiplier}px`;
        }
        else {
            currentCell.style.width = `${tenPercentWidth * (10 - secondColumnWidthMultiplier)}px`;
            currentCell.style.minWidth = `${tenPercentWidth * (10 - secondColumnWidthMultiplier)}px`;
        }
    }
}

/**
 * This function handles updating the number that is displayed in the first header cell of the All Position Details page's table, which is used to indicate how many positions match the current filters. It also handles hiding/showing the table if there are 0 positions that match the filters, as well as the navigation links to the side.
 */
function APDUpdatePositionCount() {
    let numPositions = qsa("tbody tr", tableContainer).length;
    qs("#adp-positionHeader").textContent = `Positions (${numPositions})`;
    tableContainer = (/** @type {HTMLDivElement} */ (tableContainer));
    let noPositionsDiv = qs("#APD-no-results");
    let listGroup = qs("#APD-list-group");
    let numColumnsDisplaying = qsa("th:not(.dontShow)", APDHeaderRow).length;
    if (numPositions === 0) {
        tableContainer.classList.add("dontShow");
        noPositionsDiv.classList.remove("dontShow");
        listGroup.classList.add("dontShow");
    }
    else {
        tableContainer.classList.remove("dontShow");
        noPositionsDiv.classList.add("dontShow");
        if (numColumnsDisplaying > 2) {
            listGroup.classList.remove("dontShow");
        }
    }
}

/**
 * This function returns a number based on which radio button is selected on the All Position Details page. Here are what the numbers mean:
 * 
 * 0 - Error
 * 
 * 1 - The option "Display All Positions" is selected
 * 
 * 2 - The option "Display Position With Results" is selected
 * 
 * 3 - The option "Display Position Without Results" is selected
 * 
 * @returns number
 * 
 */
function APDGetRadioButtonValue() {
    let radioButtons = (/** @type {HTMLInputElement[]} */ (qsa(`input[name="APD-display-what"]`)));
    let selectedOptionValue;
    if (radioButtons.length > 0) {
        for (let i = 0; i < radioButtons.length; i++) {
            if (radioButtons[i].checked) {
                selectedOptionValue = radioButtons[i].value;
            }
        }
    }

    if (selectedOptionValue) {
        let mode = 0;
        if (selectedOptionValue === "all") {
            mode = ALL;
        }
        else if (selectedOptionValue === "results-only") {
            mode = RESULTS;
        }
        else if (selectedOptionValue === "no-results") {
            mode = NO_RESULTS;
        }
        return mode;
    }
    return 0;
}

/**
 * This function filters the positions displayed in the All Position Details page based on two things: the radio button selected, and the text filters provided. It starts by removing all rows from the table, and then adds those that match the filters.
 */
function APDApplyFilters() {
    let mode = APDGetRadioButtonValue();
    if (mode !== 0) {
        let table = qs("table", tableContainer);
        let thead = findNearestParentOfType(APDHeaderRow, "thead");
        let tbody = document.createElement("tbody");

        table.innerHTML = "";
        table.appendChild(thead);

        // adding the rows that match the radio button selection. This is done based on CSS classes which the cells may or may not have. Cells that display text along the lines of "this position does not have X element" will have the CSS class of "empty". Therefore, the following code ensures that based on the radio button selected, every cell within the columns to display is either empty or not

        let filteredRows = APDNonHeaderRows.filter((row) => {
            if (mode === ALL) {
                return true;
            }
            let cells = qsa("td", row);
            cells = cells.slice(1, cells.length);
            if (mode === RESULTS) {
                for (let i = 0; i < cells.length; i++) {
                    if (!cells[i].classList.contains("dontShow")) {
                        if (cells[i].classList.contains("empty")) {
                            return false;
                        }
                    }
                }
                return true;
            }
            if (mode === NO_RESULTS) {
                for (let i = 0; i < cells.length; i++) {
                    if (!cells[i].classList.contains("dontShow")) {
                        if (!cells[i].classList.contains("empty")) {
                            return false;
                        }
                    }
                }
                return true;
            }
        });

        // the following loop separates the text filters into a 2D array of strings. An explanation of how it works can be found lower in the function

        let textFilter = (/** @type {HTMLInputElement} */ (qs("#APD-Filter"))).value;
        let emptyFilter = textFilter.trim() === "";

        const AND_SEPARATOR = "&";
        const OR_SEPARATOR = "|";
        const NOT_SYMBOL = "!";

        let filtersArray = [];
        if (!emptyFilter) {
            textFilter = removeMultipleWhiteSpace(textFilter).toLocaleLowerCase();
            filtersArray = textFilter.split(AND_SEPARATOR);
            for (let i = 0; i < filtersArray.length; i++) {
                let currentFilter = filtersArray[i];
                let splitFilter = currentFilter.split(OR_SEPARATOR);
                for (let j = 0; j < splitFilter.length; j++) {
                    splitFilter[j] = splitFilter[j].trim();
                }
                splitFilter = splitFilter.filter(s => s !== "" && s !== NOT_SYMBOL);
                filtersArray[i] = (/** @type {string[]} */ (splitFilter));
            }
            filtersArray = filtersArray.filter(s => s.length > 0);
        }
        if (filtersArray.length === 0) {
            emptyFilter = true;
        }

        // applying the text filters
        filteredRows = filteredRows.filter((row) => {
            if (emptyFilter) {
                return true;
            }

            let cells = qsa("td:not(.dontShow)", row);

            // the filtersArray is a 2D array of strings. Every array in the outer one is logically separated by an AND. Basically, every ampersand in the text filter input results in a separate array that will be within the filtersArray. And every single array within the filtersArray must find a match within the table row in order for it to be displayed. Now, the strings contained within the inner arrays are logically separated by an OR. This means that as soon as the inner loop finds a match on one of those strings, that array is considered a match. To find a match, the code loops through all the cells that are being displayed currently in the row, based on its CSS classes. It looks for a partial string match, with string.includes() (and is case insensitive). Also, every string element in the inner arrays that starts with a "!" behaves like a logcial NOT, which means it must not be found within any of the cells to be considered a match. So, if every array within the larger filtersArray matches for the given row, it will be part of the results displayed

            for (let j = 0; j < filtersArray.length; j++) {
                let currentFilterArrayMatches = false;

                for (let i = 0; i < filtersArray[j].length; i++) {
                    let subFilter = (/** @type {string} */ (filtersArray[j][i]));
                    let foundThisSubFilter = false;
                    let filterIsANot = false;

                    if (subFilter.charAt(0) === NOT_SYMBOL) {
                        filterIsANot = true;
                        subFilter = subFilter.substring(1);
                    }

                    for (let k = 0; k < cells.length && !foundThisSubFilter; k++) {
                        let cellText = cells[k].getAttribute("simple-text");
                        if (cellText.includes(subFilter)) {
                            foundThisSubFilter = true;
                        }
                    }
                    if ((foundThisSubFilter && !filterIsANot) || (!foundThisSubFilter && filterIsANot)) {
                        currentFilterArrayMatches = true;
                    }
                }

                if (!currentFilterArrayMatches) {
                    return false;
                }
            }
            return true;
        });

        for (let i = 0; i < filteredRows.length; i++) {
            tbody.appendChild(filteredRows[i]);
        }
        table.appendChild(tbody);
    }

    // after having applied the filters, the table must be sorted again, since some rows may have been added/removed. First, the code makes sure that if the column that was sorted is no longer being displayed, it is not sorted anymore. Then, it tries to find if there is a column currently being sorted. If there is, that means that the column which was previously sorted is still being displayed, so we sort on it again, without reversing the sort direction. If there is currently no column being sorted on (based on the CSS classes), it means that the column which was previously sorted is no longer displayed. In that case, the table gets sorted on the first column (positions) 

    // note that the sort is performed on the "simple-text" attribute of the table cells. Normally, the sort is simply performed on the textContent of the cells, which works fine in the vast majority of cases, however, when there are line breaks in an element, and you retrieve its textContent, those line breaks appear, which means that for a lot of cells in the APD page, there was a ton of whitespace in their textContent. So, to avoid that, when the page is prepared on the server, the loops that prepare the table cells run twice. On their first iteration, they are preparing a string to add as an attribute to the cell, the simple-text. The simple-text contains the same text as the actual table cell will, except it doesn't have any extra whitespace or line breaks, simply the raw text, and it is in lowercase too. That means that when the function sorts the table, it simply uses that attribute instead of formatting every cell that it goes through. This drastically improves performance, compared to other previous methods

    let columnHeaders = qsa(".sort-column", APDHeaderRow);
    for (let i = 0; i < columnHeaders.length; i++) {
        let parentCell = findNearestParentOfType(columnHeaders[i], "th");
        if (parentCell.classList.contains("dontShow")) {
            columnHeaders[i].classList.remove("sorted", "reverse-sorted");
        }
    }
    if (!qs(".sort-column.sorted") && !qs(".sort-column.reverse-sorted")) {
        sortColumn(columnHeaders[0], false, false, "simple-text");
    }
    else {
        let sortedHeader = qs(".sort-column.sorted") ? qs(".sort-column.sorted") : qs(".sort-column.reverse-sorted");
        sortColumn(sortedHeader, false, true, "simple-text");
    }

    APDUpdatePositionCount();
    APDSpyScroll();
    APDResizeCells(); // this call MUST happen after update position count, since it resizes the cells based on the width of the tableContainer, which might not be displayed before that function gets called
    toggleLoadingSymbol(false);
}

/**
 * This function gets called whenever a page loads, but only does something on the All Position Details page. If that page is the one loaded, then this function stores all table rows in variables so that they can be used later by other functions. It also adds an event listener on scroll for the tableContainer.
 */
function APDPageLoad() {
    if (qs("#APD-Filter")) {
        APDNonHeaderRows = qsa("tbody tr", tableContainer);
        APDHeaderRow = qs("thead tr", tableContainer);
        APDAllTableRows = qsa("tr", tableContainer);

        APDResizeCells();

        (/** @type {HTMLDivElement} */ (tableContainer)).addEventListener("scroll", (e) => {
            APDSpyScroll();
        });
    }
}

/**
 * This function is used on the All Position Details page. The name "spy scroll" refers to the Bootstrap component of the same name, which this function takes inspiration from (without actually using it). What it does is identify which column is being displayed when there are more than one column that can be selected from, and highlight the corresponding navigation link to the side by making its background colour blue.
 */
function APDSpyScroll() {
    if (qs("#APD-Filter")) {
        let displayedHeaderCells = qsa("th:not(.dontShow)", APDHeaderRow);
        if (displayedHeaderCells.length > 2) {
            tableContainer = (/** @type {HTMLDivElement} */ (tableContainer));
            const firstCellWidth = displayedHeaderCells[0].getBoundingClientRect().width;
    
            let links = qsa("a:not(.dontShow)", qs("#APD-list-group"));
            if (links.length > 0) {
                for (let i = 0; i < links.length; i++) {
                    links[i].classList.remove("active");
                }
                for (let i = 0; i < displayedHeaderCells.length; i++) {
                    let currentCell = displayedHeaderCells[i];
                    if (Math.abs(tableContainer.scrollLeft - (currentCell.offsetLeft - firstCellWidth)) < 30) {
                        if (links[i - 1]) { // there is one more table cell than there are links (since the first table column doesn't have a corresonding link)
                            links[i - 1].classList.add("active");
                        }
                    }
                }
            }
        }
    }
}

/**
 * This function gets called on the All Position Details page whenever a checkbox that toggles a column to display is clicked. It ensures that there always remains at least one checkbox checked.
 * 
 * @param {HTMLInputElement} checkbox - The checkbox that was clicked
 * 
 */
function APDCheckboxClicked(checkbox) {
    let checkboxes = (/** @type {HTMLInputElement[]} */ (qsa('[name="APD-columns"]')));
    let atLeastOneChecked = false;

    for (let i = 0; i < checkboxes.length && !atLeastOneChecked; i++) {
        if (checkboxes[i].checked) {
            atLeastOneChecked = true;
        }
    }
    if (!atLeastOneChecked) {
        checkbox.checked = true;
    }
}

/**
 * This function is used on the All Position Details page when a navigation link on the side of the page gets clicked. Those navigation links correspond to columns of the table, and what the function does is simply scroll the table so that the corresponding column comes into view. Since the table is not horizontally scrollable manually, this is the only way to switch between columns displayed.
 * 
 * @param {HTMLAnchorElement} link - The navigation link that was clicked on the side of the page (which corresponds to the column the user wishes to display)
 * 
 */
function APDScrollTo(link) {
    if (link) {
        let targetHeader = qs(link.getAttribute("apd-scrollto"));
        tableContainer = (/** @type {HTMLTableElement} */ (tableContainer));
        if (targetHeader) {
            if (!targetHeader.classList.contains("dontShow")) {
                let firstTableCell = qsa("th", APDHeaderRow)[0];
                tableContainer.scrollLeft = targetHeader.offsetLeft - firstTableCell.getBoundingClientRect().width;
            }
        }
    }
}

// All Position Details (APD) functions ^^^^^ ----------------------------------------------------------------------------------------------

// Page startup functions VVVVV ------------------------------------------------------------------------------------------------------------

/**
 * This function gets called whenever a page loads. It indicates on the navigation bar in which group of pages the user is currently in by adding a blue border below the corresponding link.
 */
function setSelectedNavItem() {
    let url = window.location.href.toLowerCase();
    url = url.substring(url.indexOf("/", new String("https://").length) + 1, (url.indexOf("?") > 0 ? url.indexOf("?") : url.length));
    // the url variable should represent the routing portion of the entire url (ex: /Positions/Create)

    let selectedItem;
    if (url === "" || url === "index") {
        selectedItem = "navHome";
    }
    else {
        if (url.includes("positions")) {
            selectedItem = "navPositions";
        }
        else if (url.includes("competencies")) {
            selectedItem = "navCompetencies";
        }
        else if (url.includes("similar")) {
            selectedItem = "navSimilar";
        }
        else if (url.includes("certificates") && url.includes("descriptions")) {
            selectedItem = "navCertDesc";
        }
        else if (url.includes("certificates") && !url.includes("descriptions")) {
            selectedItem = "navCertificates";
        }
    }

    let navBtn = qs(`#${selectedItem}`);
    navBtn.classList.add("selected");

    // every nav link that isn't the one with the border gets the class "smooth-underline" added to it, which gives the animation when hovered
    let navItems = qsa(".nav-item");
    for (let i = 0; i < navItems.length; i++) {
        if (!navItems[i].classList.contains("selected")) {
            let navLinks = qsa(".nav-link", navItems[i]);
            for (let i = 0; i < navLinks.length; i++) {
                navLinks[i].classList.add("smooth-underline");
            }
        }
    }

    // the compNavHider is a tiny element that is usually used to hide the competency dropdown being lowered over 6 pixels (without it, the dropdown starts appearing too high compared to where you would expect it to). Normally, that element is white, and it is located exactly where the blue border would appear below the competencies link in the nav, if it was selected. Well, when it IS selected, that white element would hide the blue border below it. So instead, it has its colour changed to match the one of the usual blue border, and it still does its job hiding the competencies dropdown when it is being lowered
    if (selectedItem === "navCompetencies") {
        let compNavHider = qs("#compNavHider");
        if (compNavHider) {
            compNavHider.style.backgroundColor = "transparent";
            setTimeout(() => {
                compNavHider.style.backgroundColor = "rgb(0, 123, 255)";
                compNavHider.style.top = "58px";
                compNavHider.style.height = "6px";
            }, 350);
        }
    }
}

/**
 * This function gets called whenever a page loads, and simply checks localStorage to see if a window scroll offset it set there (which can be set by the storeCurrentScrollPosition() function). If there is, it will apply this offset to the window, bringing users back to the same scroll position they had before reloading the page (useful in certain forms).
 */
function checkIfWindowShouldBeScrolled() {
    let scrollValue = localStorage.getItem(localStorageScrollStr);
    if (scrollValue) {
        localStorage.removeItem(localStorageScrollStr);
        if (qs(".resetWindowHeight")) {
            let numScroll = Number(scrollValue);
            if (!isNaN(numScroll)) {
                window.scrollTo(window.scrollX, numScroll);
            }
        }
    }
}

/**
 * This function removes the "title" attribute of elements that have the "tooltip" attribute on page startup, and instead sets it as the "data-original-title".
 */
function removeTitleAttributes() {
    // the reason why this function exists is the following: to use tooltips on an element, bootstrap simply says to add data-toggle="tooltip" as an attribute to the element. However, on some elements, they already have a data-toggle attribute, and it looked like they could only have one at a time. So, in those cases, the elements instead have the tooltip attribute. Normally, when bootstrap creates a tooltip element, it uses the element's title attribute as the text to display in the tooltip. When doing so, it removes that title, and sets it as another attribute, the "data-original-title". However, tooltips that get manually created because they have the tooltip attribute don't have their titles removed, so this is what this function accomplishes as well

    let items = qsa('[tooltip]');
    if (items.length > 0) {
        for (let i = 0; i < items.length; i++) {
            items[i].setAttribute("data-original-title", items[i].getAttribute("title"));
            items[i].setAttribute("title", "");
        }
    }
}

/**
 * 
 * This function gets called when a page loads. It checks if the query string contains instructions to scroll the screen to a particular element. If that is the case, this function will call another one which will perform the scroll (smoothScrollToElement()).
 * 
 * Here is how the query string should be formatted for an element to be scrolled to: include the key-value pair of "scrollTo", with the value being the HTML id of the element to be scrolled to (without the "#" in front). The value may also include some modifiers to indicate how the scroll should happen:
 * 
 * _b to indicate that the element should appear at the bottom of the screen
 * 
 * _c to indicate that the element should appear in the center of the screen
 * 
 * _n for nearest
 * 
 * _h to highlight the element scrolled into view
 * 
 * _o to click on the element, or "open" it (useful if you want to expand it)
 * 
 * Note that by default, the element will appear at the top of the screen. Parameters should be included after the id of the element, and each one should have its own underscore (ex: link.com?scrollTo=elementId_c_h_o).
 * 
 * @returns void
 * 
 */
function checkIfAnElementShouldBeScrolledIntoView() {
    let queryString = window.location.href.substring(window.location.href.indexOf("?") + 1);
    let qStringParts = queryString.split("&");

    for (let i = 0; i < qStringParts.length; i++) {
        if (qStringParts[i].includes("=")) {
            let keyValuePair = qStringParts[i].split("=");
            let key = keyValuePair[0];

            if (key.toLowerCase() === "scrollto") {
                let value = keyValuePair[1];

                let shortValue = value;
                if (value.includes("_")) {
                    shortValue = value.substring(0, value.indexOf("_"));
                    value = value.toLowerCase();
                }

                let location = "start";
                if (value.includes("_b")) {
                    location = "end";
                }
                if (value.includes("_c")) {
                    location = "center";
                }
                if (value.includes("_n")) {
                    location = "nearest";
                }

                if (qs(`#${shortValue}`)) {
                    smoothScrollToElement(qs(`#${shortValue}`), location, value.includes("_h"), value.includes("_o"));
                    return;
                }
            }
        }
    }
}

// Page startup functions ^^^^^ ------------------------------------------------------------------------------------------------------------

// Handling Events VVVVV -------------------------------------------------------------------------------------------------------------------

/**
 * This function gets called whenever a transitionstart event is fired, so when an element is expanded/collapsed. It is mainly used on the index pages for toggling the top portion of the page.
 * 
 * @param {TransitionEvent} e - The event object
 * @param {boolean} canRecurse - Whether the function can call itself again, true by default (the function can call itself without recursing after, though, for its final call)
 * @param {boolean} firstCall - Whether this is the first time it is called for this animation. Recursive calls have it set to false, and it is false by default
 * 
 */
function transitionStarted(e, canRecurse = true, firstCall = false) {
    let target = /** @type {HTMLElement} */ (e.target);

    if (tableContainer) {
        if (target.id === "collapsibleTop") {
            // this means we are on an index page, which means that the animation that started has to do with the toggling of the top part of the page
            setTableContainerMaxHeight();

            footer = /** @type {HTMLElement} */ (footer);
            if (firstCall) {
                // when the animation is happening, the body has its overflow hidden, to ensure that even if the animation would momentarily cause the body to need to scroll, it will not be able to for the duration of the transition (otherwise the scrollbar can flicker in and out of view, which is very distracting). Also, to avoid the footer moving all over, it is fixed on screen during the animation as well

                qs("body").classList.add("overflow-y-hidden");
                footer.style.position = "fixed";
                let arrowIcon = qs(`[data-target="#collapsibleTop"]`);

                let attrArr = ["alt", "data-original-title"];

                if (target.style.height) {
                    // expanding the top
                    arrowIcon.setAttribute("src", arrowIcon.getAttribute("src").substring(0, arrowIcon.getAttribute("src").lastIndexOf("/")) + "/up_arrow.png");
                    for (let i = 0; i < attrArr.length; i++) {
                        arrowIcon.setAttribute(attrArr[i], "Collapse the top of the page");
                    }
                    setSessionVariable("displayTopOfPage", "true");
                }
                else {
                    // collapsing the top
                    arrowIcon.setAttribute("src", arrowIcon.getAttribute("src").substring(0, arrowIcon.getAttribute("src").lastIndexOf("/")) + "/down_arrow.png");
                    for (let i = 0; i < attrArr.length; i++) {
                        arrowIcon.setAttribute(attrArr[i], "Expand the top of the page");
                    }
                    setSessionVariable("displayTopOfPage", "false");
                }
            }
            if (canRecurse) {
                if (qs(".collapsing")) { // this means the animation is still happening
                    setTimeout(() => { // this produces a smooth animation as the top part is animated
                        transitionStarted(e, true, false);
                    }, 20);
                }
                else {
                    // this gets fired once the animation finishes
                    transitionStarted(e, false);
                    setTableContainerMaxHeight();
                }
            }
            else {
                footer.style.position = "absolute";
                qs("body").classList.remove("overflow-y-hidden");
                setTableContainerMaxHeight();
                setTimeout(() => { // this delayed call ensures that there can't be a desync, otherwise, it can happen, very rarely
                    setTableContainerMaxHeight(true);
                }, 100);
            }
        }
    }
}

/**
 * 
 * This function gets called whenever the mouse moves, and calls other functions as is necessary.
 * 
 * @param {MouseEvent} e - The mouse moving event
 * 
 */
function mouseMoved(e) {
    checkIfCompetencyDropdownShouldDisplay(e);
}

/**
 * This function gets called whenever an input element has its value change, and in certain cases, it will call other functions to handle special baheviour.
 * 
 * @param {Event} e - The change event
 * @returns void
 * 
 */
function handleChange(e) {
    let target = /** @type {HTMLInputElement} */ (e.target);
    if (target) {
        if (target.classList) {
            if (target.classList.contains("changeCompetencyLevelDropdown")) {
                changeCompetencyLevelValue(target, target.value);
                return;
            }
            if (target.classList.contains("cert-desc-dropdown")) {
                changeCertificateDescription(target);
                return;
            }
        }
        if (target.getAttribute("name")) {
            if (target.getAttribute("name") === "changeLang") {
                swapJobTitleLanguage(target);
                return;
            }
            if (target.getAttribute("name") === "APD-display-what") {
                toggleLoadingSymbol(true);
                setTimeout(() => {
                    APDApplyFilters();
                }, 100);
                return;
            }
            if (target.getAttribute("name")) {
                if (target.getAttribute("name") === "APD-columns") {
                    APDCheckboxClicked(target);
                    return;
                }
            }
        }
    }
}

/**
 * This function gets called whenever a form is submitted and triggers other functions if necessary.
 * 
 * @param {SubmitEvent} e - The form submit event
 * @returns void
 * 
 */
function formSubmitted(e) {
    let target = /** @type {HTMLFormElement} */ (e.target);
    if (target) {
        if (target.classList) {
            if (target.classList.contains("trimFormWhenSubmitting")) {
                trimFormFields(target);
            }
        }
    }
}

/**
 * This function gets called whenever something is double clicked on the page, to then dispatch the event to another function based on what was clicked and if something should happen in that case.
 * 
 * @param {MouseEvent} e - The double click event
 * @returns void
 * 
 */
function handleDoubleClick(e) {
    let target = /** @type {HTMLElement} */ (e.target);
    e.preventDefault();
    if (target) {
        attemptToExpandCompetency(target);
        return;
    }
}

/**
 * This function gets called whenever a key is pressed. It calls other functions based on the key that was pressed, and on where it was pressed.
 * 
 * @param {KeyboardEvent} e - The key that was pressed
 * @returns void
 * 
 */
function keyPressed(e) {
    let target = /** @type {HTMLElement} */ (e.target);
    if (target) {
        if (target.id) {
            if (target.id === "APD-Filter") {
                if (e.key.toLowerCase() === "enter") { // pressing enter in the filters input of the all position details page should apply the filters
                    toggleLoadingSymbol(true);
                    setTimeout(() => {
                        APDApplyFilters();
                    }, 100);
                    return;
                }
            }
        }
    }
}

/**
 * This function gets called whenever something is clicked on the page, to then dispatch the event to another function based on what was clicked and if something should happen in that case.
 * 
 * @param {PointerEvent} e - The click event
 * @returns void
 * 
 */
function handleClick(e) {
    let target = /** @type {HTMLElement} */ (e.target);
    if (target) {
        if (target.getAttribute("data-toggle") || target.getAttribute("aria-modal") || target.getAttribute("data-dismiss")) {
            if (target.getAttribute("data-toggle") === "modal" || target.getAttribute("aria-modal") === "true" || target.getAttribute("data-dismiss") === "modal") {
                modalToggled(target);
            }
        }

        let parentLink = findNearestParentOfType(target, "a");
        if (!e.ctrlKey) {
            if (target.classList) {
                if (target.classList.contains("load-link")) {
                    toggleLoadingSymbol(true);
                }
            }
        }
        if (target.classList) {
            if (target.classList.contains("resetWindowHeight")) {
                storeCurrentScrollPosition();
                return;
            }
            if (target.classList.contains("expand-elements-in-next-rows")) {
                toggleExpandableElementsInNextRows(target);
                return;
            }
            if (target.classList.contains("plus-minus-icon")) {
                changeCompetencyLevelValue(target);
                return;
            }
            if (target.classList.contains("apd-sort")) {
                toggleLoadingSymbol(true);
                setTimeout(() => {
                    sortColumn(target, false, false, "simple-text");
                }, 100);
                return;
            }
            if (target.classList.contains("loading") && target.classList.contains("sort-column")) {
                toggleLoadingSymbol(true);
                setTimeout(() => {
                    sortColumn(target);
                }, 100);
                return;
            }
            if (target.classList.contains("sort-column-percents")) {
                sortColumn(target, true);
                return;
            }
            if (target.classList.contains("sort-column")) {
                sortColumn(target);
                return;
            }
            if (target.classList.contains("flip-column")) {
                flipColumn(target);
                return;
            }
            if (target.classList.contains("overwrite-similar-link")) {
                prepareOverwriteSimilarModalLink(target);
                return;
            }
        }
        if (target.getAttribute("apd-scrollto")) {
            e.preventDefault();
            APDScrollTo(target);
            return;
        }
        if (parentLink) {
            if (parentLink.classList) {
                if (parentLink.classList.contains("rememberIfVisited")) {
                    makeLinkVisited(parentLink, parentLink.classList.contains("nextOrPreviousLink"), e.ctrlKey);
                    return;
                }
            }
        }
        if (target.id) {
            if (target.id === "allRegionsCheckbox") {
                toggleAllCheckboxesInGroup(target, "SelectedRegionIds");
                return;
            }
            if (target.id === "apd-check-master") {
                toggleAllCheckboxesInGroup(target, "APD-columns");
                APDMakeSureOneCheckboxSelected();
                return;
            }
            if (target.id === "APD-ApplyFilters") {
                toggleLoadingSymbol(true);
                setTimeout(() => {
                    APDApplyFilters();
                }, 100);
                return;
            }
            if (target.id === "APD-ClearFilters") {
                let filterInput = (/** @type {HTMLInputElement} */ (qs("#APD-Filter")));
                if (filterInput.value !== "") { // the filters should only be cleared if they are not empty, to avoid running code unnecessarily
                    toggleLoadingSymbol(true);
                    setTimeout(() => {
                        filterInput.value = "";
                        APDApplyFilters();
                    }, 100);
                }
                return;
            }
            if (target.id === "APD-ApplyDropdownSelections") {
                toggleLoadingSymbol(true);
                setTimeout(() => {
                    APDChangeDisplayedItem();
                }, 100);
                return;
            }
        }
    }
    removeHighlights();
}

// Handling Events ^^^^^ -------------------------------------------------------------------------------------------------------------------

// Page setup VVVVV ------------------------------------------------------------------------------------------------------------------------

window.addEventListener("load", () => {
    checkIfWindowShouldBeScrolled();
    windowHeight = window.innerHeight;
    tableContainer = qs("#table-container");
    footer = qs("footer");
    let body = qs("body");
    body.addEventListener("click", (e) => {
        handleClick(e);
    });
    body.addEventListener("dblclick", (e) => {
        handleDoubleClick(e);
    });
    body.addEventListener("change", (e) => {
        handleChange(e);
    });
    body.addEventListener("submit", (e) => {
        formSubmitted(e);
    });
    body.addEventListener("mousemove", (e) => {
        mouseMoved(e);
    });
    body.addEventListener("keypress", (e) => {
        keyPressed(e);
    });
    document.addEventListener("transitionstart", (e) => {
        transitionStarted(e, true, true);
    });

    setSelectedNavItem();

    $(function () {
        $('[data-toggle="tooltip"]').tooltip();
        $('[tooltip]').tooltip();
    });

    removeTitleAttributes();

    positionCompNavHider();
    if (tableContainer && footer) {
        setTableContainerMaxHeight(true);
        checkIfTableCanBeScrolled();
    }
    window.addEventListener("resize", () => {
        if (tableContainer && footer) {
            windowHeight = window.innerHeight;
            setTableContainerMaxHeight(true);
            checkIfTableCanBeScrolled();
        }
        positionCompNavHider();
    });
    checkIfAnElementShouldBeScrolledIntoView();
    APDPageLoad();

    setTimeout(() => {
        // on pages that have the tableContainer, the body starts off with this class. This is to prevent a rare visual flicker from occuring. However, there could be some cases where the body does need to overflow, even with the tableContainer in place, so the class gets removed after a second. The same logic applies to the footer, which might start off being fixed in place to avoid being moved aroud quickly when the page loads
        if (body.classList) {
            if (body.classList.contains("overflow-y-hidden")) {
                body.classList.remove("overflow-y-hidden");
            }
        }
        footer = (/** @type {HTMLElement} */ (footer));
        if (footer.classList) {
            if (footer.classList.contains("position-fixed")) {
                footer.classList.remove("position-fixed")
            }
        }
    }, 1000);
});

// Page setup ^^^^^ ------------------------------------------------------------------------------------------------------------------------