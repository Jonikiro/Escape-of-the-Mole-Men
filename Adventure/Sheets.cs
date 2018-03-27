using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Adventure
{
    class Sheets
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        public static string[] Scopes = {SheetsService.Scope.Spreadsheets};
        public static string ApplicationName = "Text Adventure Data";

        public static void DB(string[] args)
        {
            // Template code for initial setup
            // *******************************************************************
            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });
            // *******************************************************************

            // Relevant code for updating database



            //String spreadsheetId = "1tFetfWWxEfTCuJHFySu6t8syozdTF0q4GEpbfaFQSgc";
            //String range = "Sheet1!F5";
            //ValueRange valueRange = new ValueRange
            //{
            //    MajorDimension = "COLUMNS"
            //};

            //var oblist = new List<object>() {Environment.MachineName};
            //valueRange.Values = new List<IList<object>> { oblist };

            ////SpreadsheetsResource.ValuesResource.UpdateRequest update = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            ////update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            ////UpdateValuesResponse result2 = update.Execute();
        }
    }
}