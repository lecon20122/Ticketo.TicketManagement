using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketo.TicketManagement.Application.Contracts.Infrastructure;
using Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventsExport;

namespace Ticketo.TicketManagement.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> events)
        {
            using var memoryStream = new MemoryStream();

            using (var writer = new StreamWriter(memoryStream))
            {
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(events);
            }

            return memoryStream.ToArray();
        }
    }
}
