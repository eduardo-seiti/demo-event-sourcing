// <auto-generated/>
#pragma warning disable
using Helpdesk.Api.Incidents.GetIncidentDetails;
using Marten;
using Marten.Events.Aggregation;
using Marten.Internal.Storage;
using System;
using System.Linq;

namespace Marten.Generated.EventStore
{
    // START: IncidentDetailsProjectionLiveAggregation1449511100
    public class IncidentDetailsProjectionLiveAggregation1449511100 : Marten.Events.Aggregation.SyncLiveAggregatorBase<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails>
    {
        private readonly Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetailsProjection _incidentDetailsProjection;

        public IncidentDetailsProjectionLiveAggregation1449511100(Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetailsProjection incidentDetailsProjection)
        {
            _incidentDetailsProjection = incidentDetailsProjection;
        }



        public override Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails Build(System.Collections.Generic.IReadOnlyList<Marten.Events.IEvent> events, Marten.IQuerySession session, Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails snapshot)
        {
            if (!events.Any()) return null;
            Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails incidentDetails = null;
            var usedEventOnCreate = snapshot is null;
            snapshot ??= Create(events[0], session);;
            if (snapshot is null)
            {
                usedEventOnCreate = false;
                snapshot = CreateDefault(events[0]);
            }

            foreach (var @event in events.Skip(usedEventOnCreate ? 1 : 0))
            {
                snapshot = Apply(@event, snapshot, session);
            }

            return snapshot;
        }


        public Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails Create(Marten.Events.IEvent @event, Marten.IQuerySession session)
        {
            switch (@event)
            {
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentLogged> event_IncidentLogged18:
                    return Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetailsProjection.Create(event_IncidentLogged18.Data);
                    break;
            }

            return null;
        }


        public Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails Apply(Marten.Events.IEvent @event, Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails aggregate, Marten.IQuerySession session)
        {
            switch (@event)
            {
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.AgentAssignedToIncident> event_AgentAssignedToIncident21:
                    aggregate = _incidentDetailsProjection.Apply(event_AgentAssignedToIncident21.Data, aggregate);
                    break;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.AgentRespondedToIncident> event_AgentRespondedToIncident22:
                    aggregate = _incidentDetailsProjection.Apply(event_AgentRespondedToIncident22.Data, aggregate);
                    break;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.CustomerRespondedToIncident> event_CustomerRespondedToIncident23:
                    aggregate = _incidentDetailsProjection.Apply(event_CustomerRespondedToIncident23.Data, aggregate);
                    break;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentCategorised> event_IncidentCategorised19:
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentCategorised19.Data, aggregate);
                    break;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentClosed> event_IncidentClosed26:
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentClosed26.Data, aggregate);
                    break;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentPrioritised> event_IncidentPrioritised20:
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentPrioritised20.Data, aggregate);
                    break;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentResolved> event_IncidentResolved24:
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentResolved24.Data, aggregate);
                    break;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.ResolutionAcknowledgedByCustomer> event_ResolutionAcknowledgedByCustomer25:
                    aggregate = _incidentDetailsProjection.Apply(event_ResolutionAcknowledgedByCustomer25.Data, aggregate);
                    break;
            }

            return aggregate;
        }

    }

    // END: IncidentDetailsProjectionLiveAggregation1449511100
    
    
    // START: IncidentDetailsProjectionInlineHandler1449511100
    public class IncidentDetailsProjectionInlineHandler1449511100 : Marten.Events.Aggregation.AggregationRuntime<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails, System.Guid>
    {
        private readonly Marten.IDocumentStore _store;
        private readonly Marten.Events.Aggregation.IAggregateProjection _projection;
        private readonly Marten.Events.Aggregation.IEventSlicer<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails, System.Guid> _slicer;
        private readonly Marten.Internal.Storage.IDocumentStorage<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails, System.Guid> _storage;
        private readonly Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetailsProjection _incidentDetailsProjection;

        public IncidentDetailsProjectionInlineHandler1449511100(Marten.IDocumentStore store, Marten.Events.Aggregation.IAggregateProjection projection, Marten.Events.Aggregation.IEventSlicer<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails, System.Guid> slicer, Marten.Internal.Storage.IDocumentStorage<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails, System.Guid> storage, Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetailsProjection incidentDetailsProjection) : base(store, projection, slicer, storage)
        {
            _store = store;
            _projection = projection;
            _slicer = slicer;
            _storage = storage;
            _incidentDetailsProjection = incidentDetailsProjection;
        }



        public override async System.Threading.Tasks.ValueTask<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails> ApplyEvent(Marten.IQuerySession session, Marten.Events.Projections.EventSlice<Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails, System.Guid> slice, Marten.Events.IEvent evt, Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails aggregate, System.Threading.CancellationToken cancellationToken)
        {
            switch (evt)
            {
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.AgentAssignedToIncident> event_AgentAssignedToIncident30:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_AgentAssignedToIncident30.Data, aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.AgentRespondedToIncident> event_AgentRespondedToIncident31:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_AgentRespondedToIncident31.Data, aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.CustomerRespondedToIncident> event_CustomerRespondedToIncident32:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_CustomerRespondedToIncident32.Data, aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentCategorised> event_IncidentCategorised28:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentCategorised28.Data, aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentClosed> event_IncidentClosed35:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentClosed35.Data, aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentLogged> event_IncidentLogged36:
                    aggregate = Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetailsProjection.Create(event_IncidentLogged36.Data);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentPrioritised> event_IncidentPrioritised29:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentPrioritised29.Data, aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentResolved> event_IncidentResolved33:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_IncidentResolved33.Data, aggregate);
                    return aggregate;
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.ResolutionAcknowledgedByCustomer> event_ResolutionAcknowledgedByCustomer34:
                    aggregate ??= CreateDefault(evt);
                    aggregate = _incidentDetailsProjection.Apply(event_ResolutionAcknowledgedByCustomer34.Data, aggregate);
                    return aggregate;
            }

            return aggregate;
        }


        public Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetails Create(Marten.Events.IEvent @event, Marten.IQuerySession session)
        {
            switch (@event)
            {
                case Marten.Events.IEvent<Helpdesk.Api.Incidents.IncidentLogged> event_IncidentLogged27:
                    return Helpdesk.Api.Incidents.GetIncidentDetails.IncidentDetailsProjection.Create(event_IncidentLogged27.Data);
                    break;
            }

            return null;
        }

    }

    // END: IncidentDetailsProjectionInlineHandler1449511100
    
    
}
