using CsvHelper;
using CsvHelper.Configuration;
using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
using GloboTicket.TicketManagement.Application.Feactures.Events.Queries.GetEventsExport;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace GloboTicket.TicketManagement.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventExportDtos"></param>
        /// <returns></returns>
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = (string header, int index) => header.ToLower(),
            };



            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter,config);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
