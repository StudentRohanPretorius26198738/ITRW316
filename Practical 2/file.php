<?php
$local_file = 'original.mkv'; // Change this to any file you want to download in the same directory as this script or 'somefolder/anotherfolder/filename.txt' 
$download_file = 'downloaded.mkv'; // name of the downloaded file. 

// set the download rate limit (=> 20,5 kb/s)
$download_rate = 10024;
if(file_exists($local_file) && is_file($local_file))
{
    header('Cache-control: private');
    header('Content-Type: application/octet-stream');
    header('Content-Length: '.filesize($local_file));
    header('Content-Disposition: filename='.$download_file);

    flush();
    $file = fopen($local_file, "rb");
    while(!feof($file))
    {
        // send the current file part to the browser
        print fread($file, round($download_rate * 1024));
        // flush the content to the browser
        flush();
        // sleep one second
        sleep(1);
    }
    fclose($file);}
else {
    die('Error: The file '.$local_file.' does not exist!');
}

?>
