namespace Azure.ResourceManager.ComputeSchedule
{
    public partial class AutoActionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ComputeSchedule.AutoActionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.AutoActionResource>, System.Collections.IEnumerable
    {
        protected AutoActionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ComputeSchedule.AutoActionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string autoActionName, Azure.ResourceManager.ComputeSchedule.AutoActionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string autoActionName, Azure.ResourceManager.ComputeSchedule.AutoActionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> Get(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> GetAsync(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetIfExists(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> GetIfExistsAsync(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ComputeSchedule.AutoActionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ComputeSchedule.AutoActionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ComputeSchedule.AutoActionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.AutoActionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AutoActionData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>
    {
        public AutoActionData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties Properties { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.AutoActionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.AutoActionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AutoActionResource() { }
        public virtual Azure.ResourceManager.ComputeSchedule.AutoActionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult> AttachResources(Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>> AttachResourcesAsync(Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> CancelNextOccurrence(Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> CancelNextOccurrenceAsync(Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string autoActionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult> DetachResources(Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>> DetachResourcesAsync(Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Disable(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DisableAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Enable(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> EnableAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> GetOccurrence(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> GetOccurrenceAsync(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ComputeSchedule.OccurrenceCollection GetOccurrences() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource> GetResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource> GetResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult> PatchResources(Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>> PatchResourcesAsync(Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ComputeSchedule.AutoActionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.AutoActionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.AutoActionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> TriggerManualOccurrence(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> TriggerManualOccurrenceAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> Update(Azure.ResourceManager.ComputeSchedule.AutoActionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> UpdateAsync(Azure.ResourceManager.ComputeSchedule.AutoActionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ComputeScheduleExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult> CancelVirtualMachineOperations(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>> CancelVirtualMachineOperationsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult> ExecuteVirtualMachineDeallocate(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>> ExecuteVirtualMachineDeallocateAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult> ExecuteVirtualMachineHibernate(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>> ExecuteVirtualMachineHibernateAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult> ExecuteVirtualMachineStart(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>> ExecuteVirtualMachineStartAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAutoAction(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> GetAutoActionAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.AutoActionResource GetAutoActionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.AutoActionCollection GetAutoActions(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAutoActions(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAutoActionsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources> GetAutoActionsExtensionsByVms(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources> GetAutoActionsExtensionsByVmsAsync(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.OccurrenceResource GetOccurrenceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult> GetVirtualMachineOperationStatus(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>> GetVirtualMachineOperationStatusAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult> SubmitVirtualMachineDeallocate(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>> SubmitVirtualMachineDeallocateAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult> SubmitVirtualMachineHibernate(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>> SubmitVirtualMachineHibernateAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult> SubmitVirtualMachineStart(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>> SubmitVirtualMachineStartAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class OccurrenceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>, System.Collections.IEnumerable
    {
        protected OccurrenceCollection() { }
        public virtual Azure.Response<bool> Exists(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> Get(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> GetAsync(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> GetIfExists(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> GetIfExistsAsync(string occurrenceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class OccurrenceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>
    {
        internal OccurrenceData() { }
        public Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.OccurrenceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.OccurrenceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OccurrenceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected OccurrenceResource() { }
        public virtual Azure.ResourceManager.ComputeSchedule.OccurrenceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> Cancel(Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> CancelAsync(Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string autoActionName, string occurrenceId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> Delay(Azure.ResourceManager.ComputeSchedule.Models.DelayContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> DelayAsync(Azure.ResourceManager.ComputeSchedule.Models.DelayContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.OccurrenceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource> GetResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource> GetResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.ComputeSchedule.OccurrenceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.OccurrenceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.OccurrenceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.ComputeSchedule.Mocking
{
    public partial class MockableComputeScheduleArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableComputeScheduleArmClient() { }
        public virtual Azure.ResourceManager.ComputeSchedule.AutoActionResource GetAutoActionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources> GetAutoActionsExtensionsByVms(Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources> GetAutoActionsExtensionsByVmsAsync(Azure.Core.ResourceIdentifier scope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ComputeSchedule.OccurrenceResource GetOccurrenceResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableComputeScheduleResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableComputeScheduleResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAutoAction(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.AutoActionResource>> GetAutoActionAsync(string autoActionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ComputeSchedule.AutoActionCollection GetAutoActions() { throw null; }
    }
    public partial class MockableComputeScheduleSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableComputeScheduleSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult> CancelVirtualMachineOperations(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>> CancelVirtualMachineOperationsAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult> ExecuteVirtualMachineDeallocate(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>> ExecuteVirtualMachineDeallocateAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult> ExecuteVirtualMachineHibernate(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>> ExecuteVirtualMachineHibernateAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult> ExecuteVirtualMachineStart(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>> ExecuteVirtualMachineStartAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAutoActions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ComputeSchedule.AutoActionResource> GetAutoActionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult> GetVirtualMachineOperationStatus(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>> GetVirtualMachineOperationStatusAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult> SubmitVirtualMachineDeallocate(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>> SubmitVirtualMachineDeallocateAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult> SubmitVirtualMachineHibernate(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>> SubmitVirtualMachineHibernateAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult> SubmitVirtualMachineStart(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>> SubmitVirtualMachineStartAsync(string locationparameter, Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ComputeSchedule.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionType : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ActionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ActionType Deallocate { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ActionType Hibernate { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ActionType Start { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ActionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ActionType left, Azure.ResourceManager.ComputeSchedule.Models.ActionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ActionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ActionType left, Azure.ResourceManager.ComputeSchedule.Models.ActionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmComputeScheduleModelFactory
    {
        public static Azure.ResourceManager.ComputeSchedule.AutoActionData AutoActionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties properties = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties AutoActionProperties(Azure.ResourceManager.ComputeSchedule.Models.ResourceType resourceType = default(Azure.ResourceManager.ComputeSchedule.Models.ResourceType), Azure.ResourceManager.ComputeSchedule.Models.ActionType actionType = default(Azure.ResourceManager.ComputeSchedule.Models.ActionType), System.DateTimeOffset startOn = default(System.DateTimeOffset), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule schedule = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties> notificationSettings = null, bool? disabled = default(bool?), Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult AutoActionResourceOperationResult(int totalResources = 0, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus> resourcesStatuses = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources AutoActionResources(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties properties = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult CancelOperationsResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult DeallocateResourceOperationResult(string description = null, string resourceType = null, string location = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult GetOperationStatusResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult HibernateResourceOperationResult(string description = null, string resourceType = null, string location = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> results = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.OccurrenceData OccurrenceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties properties = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties OccurrenceProperties(System.DateTimeOffset initialScheduledOn = default(System.DateTimeOffset), Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary resultSummary = null, Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState? provisioningState = default(Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState?)) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource OccurrenceResource(Azure.Core.ResourceIdentifier resourceId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties> notificationSettings = null, System.DateTimeOffset scheduledOn = default(System.DateTimeOffset), Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState? provisioningState = default(Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState?), Azure.ResponseError errorDetails = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary OccurrenceResultSummary(int total = 0, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary> statuses = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails ResourceOperationDetails(string operationId = null, string resourceId = null, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType opType = default(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType), string subscriptionId = null, System.DateTimeOffset deadline = default(System.DateTimeOffset), Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType deadlineType = default(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType), Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState state = default(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState), string timeZone = null, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError resourceOperationError = null, System.DateTimeOffset? completedOn = default(System.DateTimeOffset?), Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy retryPolicy = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError ResourceOperationError(string errorCode = null, string errorDetails = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult ResourceOperationResult(string resourceId = null, string errorCode = null, string errorDetails = null, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails operation = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary ResourceResultSummary(string code = null, int count = 0, Azure.ResponseError errorDetails = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus ResourceStatus(Azure.Core.ResourceIdentifier resourceId = null, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus status = default(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus), Azure.ResponseError error = null) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult StartResourceOperationResult(string description = null, string resourceType = null, string location = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> results = null) { throw null; }
    }
    public partial class AutoActionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties>
    {
        public AutoActionProperties(Azure.ResourceManager.ComputeSchedule.Models.ResourceType resourceType, Azure.ResourceManager.ComputeSchedule.Models.ActionType actionType, System.DateTimeOffset startOn, Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule schedule, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties> notificationSettings) { }
        public Azure.ResourceManager.ComputeSchedule.Models.ActionType ActionType { get { throw null; } set { } }
        public bool? Disabled { get { throw null; } set { } }
        public System.DateTimeOffset? EndOn { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties> NotificationSettings { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ResourceType ResourceType { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule Schedule { get { throw null; } set { } }
        public System.DateTimeOffset StartOn { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionResource : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource>
    {
        public AutoActionResource(Azure.Core.ResourceIdentifier resourceId) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties> NotificationSettings { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionResourceAttachContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent>
    {
        public AutoActionResourceAttachContent(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource> resources) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource> Resources { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceAttachContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionResourceDetachContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent>
    {
        public AutoActionResourceDetachContent(System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> resources) { }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> Resources { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceDetachContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionResourceOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>
    {
        internal AutoActionResourceOperationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus> ResourcesStatuses { get { throw null; } }
        public int TotalResources { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourceOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionResourcePatchContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent>
    {
        public AutoActionResourcePatchContent(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource> resources) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResource> Resources { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResourcePatchContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionResources : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources>
    {
        internal AutoActionResources() { }
        public Azure.ResourceManager.ComputeSchedule.Models.AutoActionProperties Properties { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionResources>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AutoActionSchedule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule>
    {
        public AutoActionSchedule(System.TimeSpan scheduledTime, string timeZone, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.WeekDay> requestedWeekDays, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ComputeSchedule.Models.Month> requestedMonths, System.Collections.Generic.IEnumerable<int> requestedDaysOfTheMonth, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail executionParameters, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType deadlineType) { }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType DeadlineType { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail ExecutionParameters { get { throw null; } set { } }
        public System.Collections.Generic.IList<int> RequestedDaysOfTheMonth { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeSchedule.Models.Month> RequestedMonths { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ComputeSchedule.Models.WeekDay> RequestedWeekDays { get { throw null; } }
        public System.TimeSpan ScheduledTime { get { throw null; } set { } }
        public string TimeZone { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.AutoActionSchedule>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CancelOccurrenceContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent>
    {
        public CancelOccurrenceContent(System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> resourceIds) { }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ResourceIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOccurrenceContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CancelOperationsContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent>
    {
        public CancelOperationsContent(System.Collections.Generic.IEnumerable<string> operationIds, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public System.Collections.Generic.IList<string> OperationIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CancelOperationsResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>
    {
        internal CancelOperationsResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> Results { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.CancelOperationsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeallocateResourceOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>
    {
        internal DeallocateResourceOperationResult() { }
        public string Description { get { throw null; } }
        public string Location { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> Results { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DeallocateResourceOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DelayContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.DelayContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DelayContent>
    {
        public DelayContent(System.TimeSpan delay, System.Collections.Generic.IEnumerable<Azure.Core.ResourceIdentifier> resourceIds) { }
        public System.TimeSpan Delay { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ResourceIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.DelayContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.DelayContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.DelayContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.DelayContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DelayContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DelayContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.DelayContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecuteDeallocateContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent>
    {
        public ExecuteDeallocateContent(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail executionParameters, Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources resources, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<string> ResourcesIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteDeallocateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecuteHibernateContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent>
    {
        public ExecuteHibernateContent(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail executionParameters, Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources resources, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<string> ResourcesIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteHibernateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExecuteStartContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent>
    {
        public ExecuteStartContent(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail executionParameters, Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources resources, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<string> ResourcesIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ExecuteStartContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GetOperationStatusContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent>
    {
        public GetOperationStatusContent(System.Collections.Generic.IEnumerable<string> operationIds, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public System.Collections.Generic.IList<string> OperationIds { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GetOperationStatusResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>
    {
        internal GetOperationStatusResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> Results { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.GetOperationStatusResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HibernateResourceOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>
    {
        internal HibernateResourceOperationResult() { }
        public string Description { get { throw null; } }
        public string Location { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> Results { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.HibernateResourceOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Language : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.Language>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Language(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.Language EnUs { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.Language other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.Language left, Azure.ResourceManager.ComputeSchedule.Models.Language right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.Language (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.Language left, Azure.ResourceManager.ComputeSchedule.Models.Language right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Month : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.Month>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Month(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month All { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month April { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month August { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month December { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month February { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month January { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month July { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month June { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month March { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month May { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month November { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month October { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.Month September { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.Month other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.Month left, Azure.ResourceManager.ComputeSchedule.Models.Month right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.Month (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.Month left, Azure.ResourceManager.ComputeSchedule.Models.Month right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NotificationProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties>
    {
        public NotificationProperties(string destination, Azure.ResourceManager.ComputeSchedule.Models.NotificationType type, Azure.ResourceManager.ComputeSchedule.Models.Language language) { }
        public string Destination { get { throw null; } set { } }
        public bool? Disabled { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeSchedule.Models.Language Language { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeSchedule.Models.NotificationType Type { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NotificationType : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.NotificationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NotificationType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.NotificationType Email { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.NotificationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.NotificationType left, Azure.ResourceManager.ComputeSchedule.Models.NotificationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.NotificationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.NotificationType left, Azure.ResourceManager.ComputeSchedule.Models.NotificationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OccurrenceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties>
    {
        internal OccurrenceProperties() { }
        public System.DateTimeOffset InitialScheduledOn { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary ResultSummary { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OccurrenceResource : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource>
    {
        internal OccurrenceResource() { }
        public Azure.ResponseError ErrorDetails { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.NotificationProperties> NotificationSettings { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
        public System.DateTimeOffset ScheduledOn { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OccurrenceResultSummary : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary>
    {
        internal OccurrenceResultSummary() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary> Statuses { get { throw null; } }
        public int Total { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceResultSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OccurrenceState : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OccurrenceState(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState Cancelling { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState Created { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState Rescheduling { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState Scheduled { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState left, Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState left, Azure.ResourceManager.ComputeSchedule.Models.OccurrenceState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState left, Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState left, Azure.ResourceManager.ComputeSchedule.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceOperationDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails>
    {
        internal ResourceOperationDetails() { }
        public System.DateTimeOffset? CompletedOn { get { throw null; } }
        public System.DateTimeOffset Deadline { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType DeadlineType { get { throw null; } }
        public string OperationId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType OpType { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError ResourceOperationError { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy RetryPolicy { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState State { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public string TimeZone { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceOperationError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError>
    {
        internal ResourceOperationError() { }
        public string ErrorCode { get { throw null; } }
        public string ErrorDetails { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult>
    {
        internal ResourceOperationResult() { }
        public string ErrorCode { get { throw null; } }
        public string ErrorDetails { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationDetails Operation { get { throw null; } }
        public string ResourceId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceOperationStatus : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceOperationStatus(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus left, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus left, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceOperationType : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceOperationType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType Deallocate { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType Hibernate { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType Start { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType left, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType left, Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceProvisioningState : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState left, Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState left, Azure.ResourceManager.ComputeSchedule.Models.ResourceProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceResultSummary : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary>
    {
        internal ResourceResultSummary() { }
        public string Code { get { throw null; } }
        public int Count { get { throw null; } }
        public Azure.ResponseError ErrorDetails { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceResultSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus>
    {
        internal ResourceStatus() { }
        public Azure.ResponseError Error { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ResourceStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceType : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ResourceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceType VirtualMachine { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ResourceType VirtualMachineScaleSet { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ResourceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ResourceType left, Azure.ResourceManager.ComputeSchedule.Models.ResourceType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ResourceType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ResourceType left, Azure.ResourceManager.ComputeSchedule.Models.ResourceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScheduledActionDeadlineType : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScheduledActionDeadlineType(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType CompleteBy { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType InitiateAt { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType left, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType left, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ScheduledActionExecutionParameterDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail>
    {
        public ScheduledActionExecutionParameterDetail() { }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference? OptimizationPreference { get { throw null; } set { } }
        public Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy RetryPolicy { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScheduledActionOperationState : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScheduledActionOperationState(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState Blocked { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState Cancelled { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState Executing { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState Failed { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState PendingExecution { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState PendingScheduling { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState Scheduled { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState left, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState left, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOperationState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScheduledActionOptimizationPreference : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScheduledActionOptimizationPreference(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference Availability { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference Cost { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference CostAvailabilityBalanced { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference left, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference left, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionOptimizationPreference right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class StartResourceOperationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>
    {
        internal StartResourceOperationResult() { }
        public string Description { get { throw null; } }
        public string Location { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ComputeSchedule.Models.ResourceOperationResult> Results { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.StartResourceOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubmitDeallocateContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent>
    {
        public SubmitDeallocateContent(Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule schedule, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail executionParameters, Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources resources, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<string> ResourcesIds { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule Schedule { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitDeallocateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubmitHibernateContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent>
    {
        public SubmitHibernateContent(Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule schedule, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail executionParameters, Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources resources, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<string> ResourcesIds { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule Schedule { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitHibernateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubmitStartContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent>
    {
        public SubmitStartContent(Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule schedule, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail executionParameters, Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources resources, string correlationId) { }
        public string CorrelationId { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionExecutionParameterDetail ExecutionParameters { get { throw null; } }
        public System.Collections.Generic.IList<string> ResourcesIds { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule Schedule { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.SubmitStartContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserRequestResources : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources>
    {
        public UserRequestResources(System.Collections.Generic.IEnumerable<string> ids) { }
        public System.Collections.Generic.IList<string> Ids { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestResources>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserRequestRetryPolicy : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy>
    {
        public UserRequestRetryPolicy() { }
        public int? RetryCount { get { throw null; } set { } }
        public int? RetryWindowInMinutes { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestRetryPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserRequestSchedule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule>
    {
        public UserRequestSchedule(System.DateTimeOffset deadLine, string timeZone, Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType deadlineType) { }
        public System.DateTimeOffset DeadLine { get { throw null; } }
        public Azure.ResourceManager.ComputeSchedule.Models.ScheduledActionDeadlineType DeadlineType { get { throw null; } }
        public string TimeZone { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ComputeSchedule.Models.UserRequestSchedule>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WeekDay : System.IEquatable<Azure.ResourceManager.ComputeSchedule.Models.WeekDay>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WeekDay(string value) { throw null; }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay All { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay Friday { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay Monday { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay Saturday { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay Sunday { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay Thursday { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay Tuesday { get { throw null; } }
        public static Azure.ResourceManager.ComputeSchedule.Models.WeekDay Wednesday { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ComputeSchedule.Models.WeekDay other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ComputeSchedule.Models.WeekDay left, Azure.ResourceManager.ComputeSchedule.Models.WeekDay right) { throw null; }
        public static implicit operator Azure.ResourceManager.ComputeSchedule.Models.WeekDay (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ComputeSchedule.Models.WeekDay left, Azure.ResourceManager.ComputeSchedule.Models.WeekDay right) { throw null; }
        public override string ToString() { throw null; }
    }
}
