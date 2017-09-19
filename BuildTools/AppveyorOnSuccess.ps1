# build should be successful if we get this far
# create a text file that contains the version number
write-host "Creating version file for https://medlaunch.info website"

if ($env:APPVEYOR_REPO_BRANCH -eq "dev")
{
	$verFile = "LatestDevVersion.txt"    
}
if ($env:APPVEYOR_REPO_BRANCH -eq "master")
{
	$verFile = "LatestMasterVersion.txt" 
}

$verNo = $env:APPVEYOR_BUILD_VERSION
New-Item $verFile -ItemType file

$verNo | Set-Content $verFile

# upload to medlaunch downloads ftp

#$username = $env:FTP_USER
#$password = $env:FTP_PASS

write-host $username

$ftp = "ftp://" + $env:FTP_USER + ":" + $env:FTP_PASS + "@185.182.58.12/domains/downloads.medlaunch.info/public_html/data/" + $verFile
$webclient = New-Object System.Net.WebClient
$uri = New-Object System.Uri($ftp)
write-host "Uploading $verFile to medlaunch downloads site"
$webclient.UploadFile($uri, $verFile)

$ftp = "ftp://" + $env:FTP_USER + ":" + $env:FTP_PASS + "@185.182.58.12/domains/medlaunch.info/public_html/" + $verFile
$webclient = New-Object System.Net.WebClient
$uri = New-Object System.Uri($ftp)
write-host "Uploading $verFile to medlaunch website"
$webclient.UploadFile($uri, $verFile)