// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Servicebus.Fluent
{
    using ResourceManager.Fluent.Core.ResourceActions;
    using TopicAuthorizationRule.Update;

    /// <summary>
    /// Type representing authorization rule defined for topic.
    /// </summary>
    public interface ITopicAuthorizationRule  :
        IAuthorizationRule<Microsoft.Azure.Management.Servicebus.Fluent.ITopicAuthorizationRule>,
        IUpdatable<TopicAuthorizationRule.Update.IUpdate>
    {
        /// <summary>
        /// Gets the name of the parent topic name.
        /// </summary>
        string TopicName { get; }

        /// <summary>
        /// Gets the name of the namespace that the parent topic belongs to.
        /// </summary>
        string NamespaceName { get; }
    }
}