﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketo.TicketManagement.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventExportQuery : IRequest<EventExportFileVm>
    {
    }
}
