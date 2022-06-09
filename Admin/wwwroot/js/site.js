let windowHeight;
let tableContainer;
let footer;
let localStorageScrollStr = "CCG_CCT_WindowScroll";
const MARGIN_BETWEEN_FOOTER_AND_TABLE = 30;

/**
 * 
 * @param {string} selector - The string which represents the desired selection
 * @param {Element} parent - Optional: the parent on which the selection is made (default is document)
 * @returns - HTMLElement[]
 * 
 * The same querySelectorAll function that you know, expect this one returns an array of HTMLElements, and you don't call it on anything, you can simply pass an optional parent parameter to it. Returns an empty array in case no elements match.
 */
function qsa(selector, parent = document) {
    if ((!selector) || (!parent)) {
        return [];
    } // if
    let result = parent.querySelectorAll(selector);
    let nodeResults = [];
    for (let i = 0; i < result.length; i++) {
        let currentNode = /** @type {HTMLElement} */ (result[i]);
        nodeResults[i] = currentNode;
    } // for
    return nodeResults;
} // qsa()

/**
 * 
 * @param {string} selector - The string which represents the desired selection
 * @param {Element} parent - Optional: the parent on which the selection is made (default is document)
 * @returns - HTMLElement
 * 
 * The same querySelector function that you know, expect this one returns a HTMLElement, and you don't call it on anything, you can simply pass an optional parent parameter to it.
 */
function qs(selector, parent = document) {
    if ((!selector) || (!parent)) {
        return null;
    } // if
    return /** @type {HTMLElement} */ (parent.querySelector(selector));
} // qs()

/**
 * This function is used on basically all Index pages, where there is a long list of elements to display. It handles setting the height of the element which contains the table and that can be scrolled through to make sure it takes up as much height as it can on screen without hiding anything. The minimum height for it is 300px.
 */
function setTableContainerMaxHeight() {
    footer = /** @type {HTMLElement} */ (footer);
    tableContainer = /** @type {HTMLElement} */ (tableContainer);
    windowHeight = /** @type {number} */ (windowHeight);

    if (tableContainer) {
        let newHeight = windowHeight - footer.getBoundingClientRect().height - tableContainer.getBoundingClientRect().y - MARGIN_BETWEEN_FOOTER_AND_TABLE;
        if (newHeight < 300) {
            newHeight = 300;
        } // if
        tableContainer.style.maxHeight = `${newHeight}px`;
    } // if
} // setTableContainerMaxHeight()

/**
 * Actions in forms which will cause the same page to be displayed can cause this function to be called which temporarily stores the current scroll offset of the window, which be applied once the page reloads (look at the checkIfWindowShouldBeScrolled() function). In order for the page scroll to be stored, the HTML element which causes the page to be reloaded (for example, the button to save changes after adding a competency in the add/edit position page) must have the css class of "resetWindowHeight".
 */
function storeCurrentScrollPosition() {
    let scrollValue = window.scrollY;
    localStorage.setItem(localStorageScrollStr, scrollValue.toString());
} // storeCurrentScrollPosition()

/**
 * This function gets called whenever a page loads, and simply checks localStorage to see if a window scroll offset it set there (which can be set by the storeCurrentScrollPosition() function). If there is, it will apply this offset to the window, bringing you back to the same scroll position you had before reloading the page (useful in certain forms)
 */
function checkIfWindowShouldBeScrolled() {
    let scrollValue = localStorage.getItem(localStorageScrollStr);
    if (scrollValue) {
        localStorage.removeItem(localStorageScrollStr);
        if (qs(".resetWindowHeight")) {
            let numScroll = Number(scrollValue);
            if (!isNaN(numScroll)) {
                window.scrollTo(window.scrollX, numScroll);
            } // if
        } // if
    } // if
} // checkIfWindowShouldBeScrolled()

/**
 * This function makes it so whenever you click on the "All Regions" checkbox on the add/edit position page, all other region checkboxes' state will match the one of the "All Regions" one. This allows you to click once to select all regions at once (and unselect them all at once as well).
 */
function toggleRegionCheckboxes() {
    let allRegionsCheckbox = /** @type {HTMLInputElement} */ (qs("#allRegionsCheckbox"));
    let otherCheckboxes = qsa(`[name="SelectedRegionIds"]`);

    if (allRegionsCheckbox && otherCheckboxes) {
        for (let i = 0; i < otherCheckboxes.length; i++) {
            (/** @type {HTMLInputElement} */ (otherCheckboxes[i])).checked = allRegionsCheckbox.checked;
        } // for
    } // if
} // toggleRegionCheckboxes()

/**
 * 
 * @param {Element} el - The child element
 * @param {string} parentTagName - The tag name of the parent desired, for exmaple "div"
 * @returns - HTMLElement
 * 
 * This function is meant to help find the nearest parent of an element of a certain type. It is limited to the tag name, meaning you can't use the full querySelector options. If no parent can be found, null will be returned.
 */
function findNearestParentOfType(el, parentTagName) {
    if ((!el) || (!parentTagName)) {
        return null;
    } // if
    if ((!el.parentElement)) {
        return null;
    } // if

    parentTagName = parentTagName.toLowerCase();
    let reachedRootNode = false;

    while (el.tagName.toLowerCase() !== parentTagName && !reachedRootNode) {
        if (el.tagName.toLowerCase() === "html" || (!el.parentElement)) {
            reachedRootNode = true;
        } // if
        else {
            el = el.parentElement;
        } // else
    } // while

    if (!reachedRootNode) {
        return /** @type {HTMLElement} */ (el);
    } // if
    return null;
} // findNearestParentOfType()

/**
 * 
 * @param {Element} el - The element whose siblings contained in the next table rows are to be expanded (usually a table header)
 * 
 * This function is used on tables headers where the elements in the next rows are expandable, for instance in the add/edit/details position page, where you can expand competencies and certificates. This function toggles every expandable element in that table, or in the case of the details page, where there are multiple subsections to the same large table, it expands every element until it meets the next "header" row of the table.
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
            } // if
        } // for

        for (let i = startingRowIndex + 1; i < allTableRows.length && endingRowIndex === -1; i++) {
            let currentRow = allTableRows[i];
            let nodesInRow = qsa("*", currentRow);
            for (let j = 0; j < nodesInRow.length; j++) {
                if (nodesInRow[j].tagName.toLowerCase() === "th") {
                    endingRowIndex = i;
                } // if
            } // for
            if (i === allTableRows.length - 1 && endingRowIndex === -1) {
                endingRowIndex = allTableRows.length;
            } // if
        } // for

        rowsToExpand = allTableRows.slice(startingRowIndex + 1, endingRowIndex);

        if (qsa(".collapsing", nearestParentTable).length === 0) { // this is to make sure that nothing happens if elements are currently being expanded/closed, otherwise the state might be slightly off
        
            if (qsa(".accordion", rowsToExpand[0]).length > 0) { // this is just to determine if there is something expandable in the rows, if not, there's no point in trying to expand the elements
    
                if (el.classList.contains("second-column")) { // this is for the competency rows/tables, where you can expand both the competency names or the levels associated to them
                    columnAffected = 2;
                } // if
    
                let expandingItems = el.classList.contains("closed");
                if (expandingItems) {
                    el.classList.remove("closed");
                    el.classList.add("opened");
                } // if
                else {
                    el.classList.add("closed");
                    el.classList.remove("opened");
                } // else

                // in the case of the add/edit position page, all expandable elements will be within the same table row. However, each item will be within a separate div.row. So, if we only have one row, and that row has at least one div.row, instead of looping through multiple table rows, we will now loop through those div.row. The rest of the code behaves the same
                if (qsa("td div.row", rowsToExpand[0]).length > 0 && rowsToExpand.length === 1) {
                    rowsToExpand = qsa("td div.row", rowsToExpand[0]);
                } // if
    
                for (let i = 0; i < rowsToExpand.length; i++) {
                    let btnsInRow = qsa("button.btn", rowsToExpand[i]);
            
                    for (let i = 0; i < btnsInRow.length; i++) {
                        if ((i + 1) === columnAffected) {
                            if ((expandingItems && btnsInRow[i].getAttribute("aria-expanded") === "false") || (!expandingItems && btnsInRow[i].getAttribute("aria-expanded") === "true"))
                            btnsInRow[i].click();
                        } // if
                    } // for
                } // for
            } // if
        } // if
    } // if
} // toggleExpandableElementsInNextRows()

/**
 * 
 * @param {HTMLElement} dropdown - The dropdown which had its value updated
 * 
 * This function gets called whenever a dropdown to change a competency's level gets updated, either by the dropdown itself, or by the + or - buttons. It ensures that if the dropdown is at its maximum or minimum value, the corresponding button gets disabled (and re-enabled if the value changes again and is no longer at an extreme).
 */
function checkCompetencyLevelButtonsState(dropdown) {
    let dropDown = /** @type {HTMLInputElement} */ (dropdown);
    let minusButton = dropDown.previousElementSibling;
    let plusButton = dropDown.nextElementSibling;

    let currentValue = Number(dropDown.value);
    let maxValue = getMaximumOrMinimumValueFromDropdown(dropDown);
    let minValue = getMaximumOrMinimumValueFromDropdown(dropDown, false);

    minusButton.classList.remove("disabled");
    plusButton.classList.remove("disabled");

    if (currentValue === minValue) {
        minusButton.classList.add("disabled");
    } // if
    if (currentValue === maxValue) {
        plusButton.classList.add("disabled");
    } // if
} // checkCompetencyLevelButtonsState()

/**
 * 
 * @param {HTMLElement} dropdown - The "select" HTML element
 * @param {Boolean} maximum - True by default. If set to true, will return the maximum, and the minimum otherwise
 * @returns Number
 * 
 * This function returns the maximum or minimum "value" attribute of all option elements contained within the dropdown. Returns null if there are no options in the dropdown.
 */
function getMaximumOrMinimumValueFromDropdown(dropdown, maximum = true) {
    let dropdownOptions = qsa("option", dropdown);
    if (dropdownOptions.length > 0) {
        let dropdownValues = [];
        for (let i = 0; i < dropdownOptions.length; i++) {
            dropdownValues[i] = /** @type {Number} */ ((/** @type {HTMLInputElement} */ (dropdownOptions[i])).value);
        } // for
        return maximum ? Math.max(...dropdownValues) : Math.min(...dropdownValues);
    } // if
    return null;
} // getMaximumValueFromDropdown()

/**
 * 
 * @param {HTMLElement} el - The HTMLElement which caused the function to be called, either a + or - button, or a competency level dropdown
 * @param {Number} newNum - The new competency level. It will be set if this function gets called by selecting the dropdown value
 * 
 * This function replaces all formaction attributes on the page (add/edit position) whenever a competency level is changed. In doing so, users are able to change the level of a competency without having to remove and add the competency again. If the function gets called by pressing the + or - button, this function also replaces the associated dropdown with the updated number.
 */
function changeCompetencyLevelValue(el, newNum = null) {
    let newDropdownValue;
    let valueChanged;
    let dropdown;

    if (newNum) {
        valueChanged = true;
        newDropdownValue = newNum;
        dropdown = el;
    } // if
    else {
        let increment = true;
    
        if (el.classList.contains("minus-icon")) {
            dropdown = el.nextElementSibling;
            increment = false;
        } // if
        else {
            dropdown = el.previousElementSibling;
        } // else
        dropdown = /** @type {HTMLInputElement} */ (dropdown);
    
        let originalDropdownValue = Number(dropdown.value);
        let maxDropdownValue = getMaximumOrMinimumValueFromDropdown(dropdown);
        let minDropdownValue = getMaximumOrMinimumValueFromDropdown(dropdown, false);

        if (increment && originalDropdownValue < maxDropdownValue) {
            dropdown.value = originalDropdownValue + 1;
        } // if
        if (!increment && originalDropdownValue > minDropdownValue) {
            dropdown.value = originalDropdownValue - 1;
        } // if

        newDropdownValue = Number(dropdown.value);
        valueChanged = (originalDropdownValue !== newDropdownValue);
    } // else

    if (valueChanged) {
        checkCompetencyLevelButtonsState(dropdown);
        const ENCODED_AMPERSAND = encodeURIComponent("&");
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
        } // switch
        fullCompetencyStr = /** @type {String} */ (fullCompetencyStr);

        for (let i = 0; i < formActionElements.length; i++) {
            let formActionElement = formActionElements[i];
            let formActionStr = formActionElement.getAttribute("formaction");  
    
            let competencyIdsStr = formActionStr.substring((formActionStr.indexOf(fullCompetencyStr) + fullCompetencyStr.length + 1), 
                (formActionStr.indexOf("-&", (formActionStr.indexOf(fullCompetencyStr) + 1))));

            let endIndex = competencyIdsStr.indexOf("-", (competencyIdsStr.indexOf(compId.toString().concat(ENCODED_AMPERSAND)))) < 0 ? competencyIdsStr.length :
                competencyIdsStr.indexOf("-", (competencyIdsStr.indexOf(compId.toString().concat(ENCODED_AMPERSAND))));

            let competencyToUpdateStr = competencyIdsStr.substring((competencyIdsStr.indexOf(compId.toString().concat(ENCODED_AMPERSAND))), 
            endIndex);

            let updatedCompetencyStr = competencyToUpdateStr.substring(0, competencyToUpdateStr.indexOf(ENCODED_AMPERSAND) + ENCODED_AMPERSAND.length).concat(newDropdownValue.toString());

            let formActionStrArr = formActionStr.split('');
            formActionStrArr.splice(formActionStr.indexOf(competencyToUpdateStr), competencyToUpdateStr.length, updatedCompetencyStr);
            let updatedFormActionStr = formActionStrArr.join('');
    
            formActionElement.setAttribute("formaction", updatedFormActionStr);
        } // for
    } // if
} // changeCompetencyLevelValue()

/**
 * 
 * @param {Event} e - The change event
 * @returns - void
 * 
 * This function gets called whenever an input element has its value change, and in certain cases, it will call other functions to handle special baheviour.
 */
 function handleChange(e) {
    let target = /** @type {HTMLInputElement} */ (e.target);
    if (target) {
        if (target.classList) {
            if (target.classList.contains("changeCompetencyLevelDropdown")) {
                changeCompetencyLevelValue(target, target.value);
                return;
            } // if
        } // if
    } // if
} // handleChange()

/**
 * 
 * @param {Event} e - The click event
 * @returns - void
 * 
 * This function gets called whenever something is clicked on the page, to then dispatch the event to another function based on what was clicked and if something should happen in that case.
 */
 function handleClick(e) {
    let target = /** @type {HTMLElement} */ (e.target);
    if (target) {
        if (target.classList) {
            if (target.classList.contains("resetWindowHeight")) {
                storeCurrentScrollPosition();
                return;
            } // if
            if (target.classList.contains("expand-elements-in-next-rows")) {
                toggleExpandableElementsInNextRows(target);
                return;
            } // if
            if (target.classList.contains("plus-minus-icon")) {
                changeCompetencyLevelValue(target);
                return;
            } // if
        } // if
        if (target.id) {
            if (target.id === "allRegionsCheckbox") {
                toggleRegionCheckboxes();
                return;
            } // if
        } // if
    } // if
} // handleClick()

// Page setup when it has loaded. Adds the appropriate event listeners and such
window.addEventListener("load", () => {
    windowHeight = window.innerHeight;
    tableContainer = qs("#table-container");
    footer = qs("footer");
    qs("body").addEventListener("click", (e) => {
        handleClick(e);
    });
    qs("body").addEventListener("change", (e) => {
        handleChange(e);
    });

    checkIfWindowShouldBeScrolled();

    if (tableContainer && footer) {
        setTableContainerMaxHeight();
        window.addEventListener("resize", () => {
            windowHeight = window.innerHeight;
            setTableContainerMaxHeight();
        });
    } // if
});