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
            // *******************************************************************
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
            // "var" can be used when storing a reference to an object of an anonymous type, 
            // which can't be known in advance. Normally, it just lets the compiler infer the data type.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            // *******************************************************************
            // Relevant code for updating database
            // *******************************************************************

            // These are the variables each API method needs to operate
            String spreadsheetId = "1tFetfWWxEfTCuJHFySu6t8syozdTF0q4GEpbfaFQSgc";
            String range = "Sheet1!A:C";
            // Curly braces allow you to specify property parameters on initialization
            // Object initializers like this let you set properties after construction, but before use.
            // Apparently you can omit parentheses when creating a new object!
            ValueRange valueRange = new ValueRange { MajorDimension = "COLUMNS" };

            // This is the list of values which will be inserted into the table.
            // The ValueRange object takes 2D lists, in which the inner list is the cell by cell data
            // and the outer list is each row/column (depending on which MajorDimension is indicated).
            // Object is used as a data type that can accept any values!
            var oblist = new List<object>() { Environment.MachineName, "fuck", "duck", "truck" };
            var oblist2 = new List<object>() { Environment.MachineName + " special", "suck", "muck", "luck" };
            var oblist3 = new List<object>() { "TestUlt", "Test", "test", "Test" };

            // This particular list is the outer list. It contains all the lists of data from before, one per dimension.
            valueRange.Values = new List<IList<object>> { oblist, oblist2, oblist3 };
            
            // The following code pushes data to the spreadsheet.
            SpreadsheetsResource.ValuesResource.UpdateRequest update = service.Spreadsheets.Values.Update(valueRange, spreadsheetId, range);
            update.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            UpdateValuesResponse result2 = update.Execute();

            // The following code pulls data from the spreadsheet.
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            Console.WriteLine(values[1][1]);
            Console.Read();

            // *******************************************************************
        }
    }
}