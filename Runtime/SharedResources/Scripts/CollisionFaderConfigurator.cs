namespace Tilia.Visuals.CollisionFader
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Tracking.Collision;
    using Zinnia.Tracking.Collision.Event.Proxy;
    using Zinnia.Tracking.Follow;
    using Zinnia.Visual;

    /// <summary>
    /// Sets up the CollisionFader prefab based on the provided user settings.
    /// </summary>
    public class CollisionFaderConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private CollisionFaderFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public CollisionFaderFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked ObjectFollower to attach the source to.")]
        [SerializeField]
        [Restricted]
        private ObjectFollower sourceFollower;
        /// <summary>
        /// The linked <see cref="ObjectFollower"/> to attach the source to.
        /// </summary>
        public ObjectFollower SourceFollower
        {
            get
            {
                return sourceFollower;
            }
            protected set
            {
                sourceFollower = value;
            }
        }
        [Tooltip("The linked CollisionTracker to track collisions with.")]
        [SerializeField]
        [Restricted]
        private CollisionTracker sourceCollisionTracker;
        /// <summary>
        /// The linked <see cref="CollisionTracker"/> to track collisions with.
        /// </summary>
        public CollisionTracker SourceCollisionTracker
        {
            get
            {
                return sourceCollisionTracker;
            }
            protected set
            {
                sourceCollisionTracker = value;
            }
        }
        [Tooltip("The linked CollisionNotifierEventProxyEmitter to set the valid collisions rule on.")]
        [SerializeField]
        [Restricted]
        private CollisionNotifierEventProxyEmitter collisionProxy;
        /// <summary>
        /// The linked <see cref="CollisionNotifierEventProxyEmitter"/> to set the valid collisions rule on.
        /// </summary>
        public CollisionNotifierEventProxyEmitter CollisionProxy
        {
            get
            {
                return collisionProxy;
            }
            protected set
            {
                collisionProxy = value;
            }
        }
        [Tooltip("The linked CameraColorOverlay to use to fade the camera.")]
        [SerializeField]
        [Restricted]
        private CameraColorOverlay fadeOverlay;
        /// <summary>
        /// The linked <see cref="CameraColorOverlay"/> to use to fade the camera.
        /// </summary>
        public CameraColorOverlay FadeOverlay
        {
            get
            {
                return fadeOverlay;
            }
            protected set
            {
                fadeOverlay = value;
            }
        }
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
            if (SourceCollisionTracker != null)
            {
                SourceCollisionTracker.ForwardingSourceValidity = Facade.CollisionValidity;
            }

            if (CollisionProxy != null)
            {
                CollisionProxy.ReceiveValidity = Facade.CollisionValidity;
            }
        }

        /// <summary>
        /// Sets up the <see cref="FadeOverlay"/> with the relevant scene camera rules.
        /// </summary>
        public virtual void SetupFadeOverlay()
        {
            FadeOverlay.CameraValidity = FadeOverlay.CameraValidity;
        }

        /// <summary>
        /// Emits the <see cref="Facade.Faded"/> event.
        /// </summary>
        public virtual void NotifyFaded()
        {
            Facade.Faded?.Invoke();
        }

        /// <summary>
        /// Emits the <see cref="Facade.Unfaded"/> event.
        /// </summary>
        public virtual void NotifyUnfaded()
        {
            Facade.Unfaded?.Invoke();
        }

        protected virtual void OnEnable()
        {
            SetupFollower();
            SetupCollisionRule();
            SetupFadeOverlay();
        }
    }
}