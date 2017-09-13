﻿write-host "Starting MedLaunch pre-release packaging scripts.."

# get current directory (this will be something/something/BuildTools)
# so root would be $loc\..\
$loc = Split-Path $script:MyInvocation.MyCommand.Path
$root = (get-item $loc).parent.FullName
$releaseString = "$root\MedLaunch\bin\Release"
$lib = "$releaseString\lib"

# remove unneeded files
write-host "Removing unneeded *.xml and *.pdb files..."
$xml = get-childitem $lib -recurse
foreach ($thing in $xml)
{
    if ($thing -like "*.xml" -or $thing -like "*.pdb")
    {
        $relative = $lib.Replace($root, "") + "\$thing"
        $absolute = "$lib\$thing"
        write-host "Deleting $relative"
        #write-host "Deleting $absolute"
        
        Remove-Item -path $absolute -force
    }
    
}
# EOF   