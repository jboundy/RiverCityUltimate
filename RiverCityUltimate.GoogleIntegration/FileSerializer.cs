using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using RiverCityUltimate.GoogleIntegration.Models;

namespace RiverCityUltimate.GoogleIntegration
{
    public class FileSerializer
    {
        public async Task<IndexBody> SerializeIndex(FilesResource.ExportRequest request)
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

            return (IndexBody)await request.DownloadAsync(stream);
        }
    }
}
