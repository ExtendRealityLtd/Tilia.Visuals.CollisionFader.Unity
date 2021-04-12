namespace Tilia.Visuals.CollisionFader
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Rule;

    /// <summary>
    /// The public interface for the CollisionFader prefab.
    /// </summary>
    public class CollisionFaderFacade : MonoBehaviour
    {
        #region Tracking Settings
        /// <summary>
        /// The source for the internal <see cref="Collider"/> to follow.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Tracking Settings"), DocumentedByXml]
        public GameObject Source { get; set; }
        /// <summary>
        /// The rules to determine which scene cameras to apply the overlay to.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Cleared]
        public RuleContainer CameraValidity { get; set; }
        /// <summary>
        /// The rules to determine which colliders in the scene will activate the fade.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Cleared]
        public RuleContainer CollisionValidity { get; set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public CollisionFaderConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Called after <see cref="Source"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(Source))]
        protected virtual void OnAfterSourceChange()
        {
            Configuration.SetupFollower();
        }

        /// <summary>
        /// Called after <see cref="CameraValidity"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(CameraValidity))]
        protected virtual void OnAfterCameraValidityChange()
        {
            Configuration.SetupFadeOverlay();
        }

        /// <summary>
        /// Called after <see cref="CollisionValidity"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(CollisionValidity))]
        protected virtual void OnAfterCollisionValidityChange()
        {
            Configuration.SetupCollisionRule();
        }
    }
}