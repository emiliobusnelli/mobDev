using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.DynamoDBv2.Model;

namespace AWSDemo
{
    public class MainPageViewModel : GalaSoft.MvvmLight.ViewModelBase
    {
        public MainPageViewModel()
        {
            FetchData();
        }

        public IEnumerable<object> Data { private set; get; }

        private async Task FetchData()
        {
            // Initialize the Amazon Cognito credentials provider
            CognitoAWSCredentials credentials = new CognitoAWSCredentials(
                "us-east-2:5e05b7b5-b2c4-42aa-8660-7f19536d6f5b", // Identity pool ID
                RegionEndpoint.USEast2 // Region
            );

            var ddbClient = new Amazon.DynamoDBv2.AmazonDynamoDBClient(credentials, Amazon.RegionEndpoint.USEast2);

            var result = await ddbClient.ScanAsync(new ScanRequest
            {
                TableName = "AWSDemoData",
                AttributesToGet = new List<string> { "Author", "BookTitle"}
            });

            Data = result.Items.Select(i => new
            {
                Author = i["Author"].S,
                BookTitle = i["BookTitle"].S
            });

            RaisePropertyChanged(nameof(Data));
        }
    }
}
