param
( 
	[String] [Parameter(Mandatory = $true)] [Alias("fp")] $FilePath,
	[hashTable] [Parameter(Mandatory = $false)] [Alias("env")]  $environmentVariables
)

$doc = New-Object System.Xml.XmlDocument
Write-Host "Opening web.config file" -ForegroundColor Green
$doc.Load($FilePath)

$core = $doc.SelectSingleNode('//configuration/system.webServer/aspNetCore')

$variables = $doc.CreateNode("element", "environmentVariables", $null)
$core.appendChild($variables) | Out-Null


$params = $environmentVariables.GetEnumerator() | ForEach-Object { 
  $node = $doc.CreateNode("element", "environmentVariable", $null)
  $node.SetAttribute("name", $_.Key) | Out-Null
  $node.SetAttribute("value", $_.Value) | Out-Null
  $variables.appendChild($node) | Out-Null
}

Write-Host "Saving the XML document to $Path" -ForegroundColor Green
$doc.save($FilePath)

Write-Host "Finished!" -ForegroundColor green

Copy-Item appsettings.aps.Development.json appsettings.Development.json
Copy-Item appsettings.aps.Test.json appsettings.Test.json
Copy-Item appsettings.aps.Production.json appsettings.Production.json