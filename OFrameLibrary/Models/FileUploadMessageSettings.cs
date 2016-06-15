﻿namespace OFrameLibrary.Models
{
    public class FileUploadMessageSettings
    {
        public string Failed { get; set; } = "File Upload Failed";
        public string FileSizeInvalid { get; set; } = "File Too Large";
        public string NoFileSelected { get; set; } = "No File Selected";
        public string Success { get; set; } = "File Uploaded Successfully";
    }
}