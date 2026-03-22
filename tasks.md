@jeremydmiller
I've put together a roadmap for the RoutingSlip implementation, marking off completed tasks. I'm a bit tied up right now, but I expect to wrap it up in a couple of weeks.
Implemented

    Routing slip model with TrackingNumber, CreateTimestamp, remaining activities, and execution log
    Sequential activity execution (next activity is dequeued and sent)
    Reverse-order compensation (last executed activity compensated first)
    Basic routing slip builder (AddActivity(name, destinationUri))
    Routing slip startup integration via UseRoutingSlip(...)
    Middleware-driven orchestration for execution and compensation success paths
    Failure handling hook with configurable policy override (RoutingSlipOptions.OverridePolicy)
    Default failure transition behavior that discards the failed envelope and triggers coordinator callbacks
    Activity failure event publication (RoutingSlipActivityFailed)
    Compensation failure event publication (RoutingSlipCompensationFailed)
    Serializable exception mapping (ExceptionInfo) including inner exceptions
    End-to-end tests for happy path, execution failure, compensation flow, compensation failure, and retry override

Needs To Be Done

    Activity arguments payload per itinerary step
    Global routing slip variables and variable mutation during execution
    Separate execute and compensate addresses per activity
    Full routing slip event model (completed, faulted, activity completed/faulted, compensation completed/failed, etc.)
    Subscription model for routing slip events (multiple subscribers, event filters, content options)
    Rich execution result semantics (e.g., complete with variables, revise itinerary, terminate, explicit fault outcomes)
    Compensation log data payload per executed activity (not just name/URI/execution id)
    Stronger fault metadata and correlation fields for observability/interoperability
