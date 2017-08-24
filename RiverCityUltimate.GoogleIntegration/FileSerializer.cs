using System;
using System.IO;
using System.Threading.Tasks;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

namespace RiverCityUltimate.GoogleIntegration
{
    public class FileSerializer
    {
        private readonly DriveService _drive;
        private readonly SheetsService _sheets;
        public FileSerializer(DriveService drive, SheetsService sheets)
        {
            _drive = drive;
            _sheets = sheets;
        }

        public SpreadsheetsResource.GetRequest SpreadsheetRequest(string spreadSheetId)
        {
            return _sheets.Spreadsheets.Get(spreadSheetId);
        }

        public async Task<Spreadsheet> SheetStream(SpreadsheetsResource.GetRequest request)
        {
            return await request.ExecuteAsync();
        }

        public FilesResource.ExportRequest FileRequest(string fileId)
        {
            return _drive.Files.Export(fileId, "text/plain");
        }

        public async Task<IDownloadProgress> FileStream(FilesResource.ExportRequest request)
        {
            MemoryStream stream = new MemoryStream();

            request.MediaDownloader.ProgressChanged +=
                progress =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                        {
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                        case DownloadStatus.Completed:
                        {
                            Console.WriteLine("Download complete.");
                            break;
                        }
                        case DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
                            break;
                        }
                    }
                };

            return await request.DownloadAsync(stream);
        }
    }
}
