using System;
using System.IO;
using System.Text;

using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Amazon.DynamoDBv2.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda1
{
    public class Function
    {
        public void FunctionHandler(DynamoDBEvent dynamoEvent, ILambdaContext context)
        {
            context.Logger.LogLine($"Beginning to process {dynamoEvent.Records.Count} records...");

            foreach (var record in dynamoEvent.Records)
            {
                context.Logger.LogLine($"Event ID: {record.EventID}");
                context.Logger.LogLine($"Event Name: {record.EventName}");
            }

            context.Logger.LogLine("Stream processing complete.");

            /* 
             * Output from the Mock Lambda Test Tool
             * 
             * Beginning to process 3 records...
                    Event ID: 1
                    Event Name: INSERT
                    Event ID: 2
                    Event Name: MODIFY
                    Event ID: 3
                    Event Name: REMOVE
                    Stream processing complete.
             */

            /*
             * Output on AWS:
             * START RequestId: 7b570048-6c18-4f4b-9511-97c65fc92f9d Version: $LATEST
                    Beginning to process 3 records...
                    Event ID: c4ca4238a0b923820dcc509a6f75849b
                    Event Name: INSERT
                    Event ID: c81e728d9d4c2f636f067f89cc14862c
                    Event Name: MODIFY
                    Event ID: eccbc87e4b5ce2fe28308fd9f2a7baf3
                    Event Name: REMOVE
                    Stream processing complete.
                    END RequestId: 7b570048-6c18-4f4b-9511-97c65fc92f9d
                    REPORT RequestId: 7b570048-6c18-4f4b-9511-97c65fc92f9d	Duration: 413.47 ms	Billed Duration: 414 ms	Memory Size: 256 MB	Max Memory Used: 65 MB	Init Duration: 172.29 ms
             */
        }
    }
}