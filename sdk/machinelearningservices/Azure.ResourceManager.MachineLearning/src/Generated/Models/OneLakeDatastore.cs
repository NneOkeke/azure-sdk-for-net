// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> OneLake (Trident) datastore configuration. </summary>
    public partial class OneLakeDatastore : MachineLearningDatastoreProperties
    {
        /// <summary> Initializes a new instance of <see cref="OneLakeDatastore"/>. </summary>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="artifact">
        /// [Required] OneLake artifact backing the datastore.
        /// Please note <see cref="OneLakeArtifact"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LakeHouseArtifact"/>.
        /// </param>
        /// <param name="oneLakeWorkspaceName"> [Required] OneLake workspace name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/>, <paramref name="artifact"/> or <paramref name="oneLakeWorkspaceName"/> is null. </exception>
        public OneLakeDatastore(MachineLearningDatastoreCredentials credentials, OneLakeArtifact artifact, string oneLakeWorkspaceName) : base(credentials)
        {
            Argument.AssertNotNull(credentials, nameof(credentials));
            Argument.AssertNotNull(artifact, nameof(artifact));
            Argument.AssertNotNull(oneLakeWorkspaceName, nameof(oneLakeWorkspaceName));

            Artifact = artifact;
            OneLakeWorkspaceName = oneLakeWorkspaceName;
            DatastoreType = DatastoreType.OneLake;
        }

        /// <summary> Initializes a new instance of <see cref="OneLakeDatastore"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="credentials">
        /// [Required] Account credentials.
        /// Please note <see cref="MachineLearningDatastoreCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreCredentials"/>, <see cref="MachineLearningCertificateDatastoreCredentials"/>, <see cref="MachineLearningNoneDatastoreCredentials"/>, <see cref="MachineLearningSasDatastoreCredentials"/> and <see cref="MachineLearningServicePrincipalDatastoreCredentials"/>.
        /// </param>
        /// <param name="artifact">
        /// [Required] OneLake artifact backing the datastore.
        /// Please note <see cref="OneLakeArtifact"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LakeHouseArtifact"/>.
        /// </param>
        /// <param name="oneLakeWorkspaceName"> [Required] OneLake workspace name. </param>
        /// <param name="endpoint"> OneLake endpoint to use for the datastore. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer's storage. </param>
        internal OneLakeDatastore(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, DatastoreType datastoreType, bool? isDefault, MachineLearningDatastoreCredentials credentials, OneLakeArtifact artifact, string oneLakeWorkspaceName, string endpoint, MachineLearningServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity) : base(description, tags, properties, serializedAdditionalRawData, datastoreType, isDefault, credentials)
        {
            Artifact = artifact;
            OneLakeWorkspaceName = oneLakeWorkspaceName;
            Endpoint = endpoint;
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            DatastoreType = datastoreType;
        }

        /// <summary> Initializes a new instance of <see cref="OneLakeDatastore"/> for deserialization. </summary>
        internal OneLakeDatastore()
        {
        }

        /// <summary>
        /// [Required] OneLake artifact backing the datastore.
        /// Please note <see cref="OneLakeArtifact"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LakeHouseArtifact"/>.
        /// </summary>
        [WirePath("artifact")]
        public OneLakeArtifact Artifact { get; set; }
        /// <summary> [Required] OneLake workspace name. </summary>
        [WirePath("oneLakeWorkspaceName")]
        public string OneLakeWorkspaceName { get; set; }
        /// <summary> OneLake endpoint to use for the datastore. </summary>
        [WirePath("endpoint")]
        public string Endpoint { get; set; }
        /// <summary> Indicates which identity to use to authenticate service data access to customer's storage. </summary>
        [WirePath("serviceDataAccessAuthIdentity")]
        public MachineLearningServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
    }
}
