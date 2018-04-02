using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Data = Google.Apis.Sheets.v4.Data;



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
            
            // API code used to generate an access token for current user.
            UserCredential credential;

            // Using statement essentially releases FileStream object once it is no longer needed.
            // This code opens the credential file this API just set up previously.
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                // Opens client-side browser to authenticate end-user with their google account.
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
            String spreadsheetId = "1tFetfWWxEfTCuJHFySu6t8syozdTF0q4GEpbfaFQSgc";
            String range = "Sheet1!A:A";
            ValueRange valueRange = new ValueRange { MajorDimension = "COLUMNS" };

            var oblist = new List<object>() { Environment.MachineName };
            // var oblist = new List<object>();
            oblist.Add("TestUlt");
            valueRange.Values = new List<IList<object>> { oblist };
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            Data.ValueRange response = request.Execute();
            
            SpreadsheetsResource.ValuesResource.UpdateRequest update = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            UpdateValuesResponse result2 = update.Execute();
        }
    }
}