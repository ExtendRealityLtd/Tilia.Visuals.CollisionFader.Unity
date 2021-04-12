namespace Tilia.Visuals.CollisionFader
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Tracking.Collision.Event.Proxy;
    using Zinnia.Tracking.Follow;
    using Zinnia.Visual;

    /// <summary>
    /// Sets up the CollisionFader prefab based on the provided user settings.
    /// </summary>
    public class CollisionFaderConfigurator : MonoBehaviour
    {
        #region Facade Settings
        /// <summary>
        /// The public interface facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public CollisionFaderFacade Facade { get; protected set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked <see cref="ObjectFollower"/> to attach the source to.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public ObjectFollower SourceFollower { get; protected set; }
        /// <summary>
        /// The linked <see cref="CollisionNotifierEventProxyEmitter"/> to set the valid collisions rule on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public CollisionNotifierEventProxyEmitter CollisionProxy { get; protected set; }
        /// <summary>
        /// The linked <see cref="CameraColorOverlay"/> to use to fade the camera.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public CameraColorOverlay FadeOverlay { get; protected set; }
        #endregion

        /// <summary>
        /// Sets up the <see cref="SourceFollower"/> component with the relevant source.
        /// </summary>
        public virtual void SetupFollower()
        {
            if (Facade.Source == null)
            {
                return;
            }

            SourceFollower.RunWhenActiveAndEnabled(() => SourceFollower.Sources.Clear());
            SourceFollower.RunWhenActiveAndEnabled(() => SourceFollower.Sources.Add(Facade.Source));
        }

        /// <summary>
        /// Sets up the <see cref="CollisionProxy"/> with the relevant collision rules.
        /// </summary>
        public virtual void SetupCollisionRule()
        {
            CollisionProxy.ReceiveValidity = Facade.CollisionValidity;
        }

        /// <summary>
        /// Sets up the <see cref="FadeOverlay"/> with the relevant scene camera rules.
        /// </summary>
        public virtual void SetupFadeOverlay()
        {
            FadeOverlay.CameraValidity = FadeOverlay.CameraValidity;
        }

        protected virtual void OnEnable()
        {
            SetupFollower();
            SetupCollisionRule();
            SetupFadeOverlay();
        }
    }
}