﻿namespace Tilia.Visuals.CollisionFader
{
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Rule;

    /// <summary>
    /// The public interface for the CollisionFader prefab.
    /// </summary>
    public class CollisionFaderFacade : MonoBehaviour
    {
        #region Tracking Settings
        [Header("Tracking Settings")]
        [Tooltip("The source for the internal Collider to follow.")]
        [SerializeField]
        private GameObject source;
        /// <summary>
        /// The source for the internal <see cref="Collider"/> to follow.
        /// </summary>
        public GameObject Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSourceChange();
                }
            }
        }
        [Tooltip("The rules to determine which scene cameras to apply the overlay to.")]
        [SerializeField]
        private RuleContainer cameraValidity;
        /// <summary>
        /// The rules to determine which scene cameras to apply the overlay to.
        /// </summary>
        public RuleContainer CameraValidity
        {
            get
            {
                return cameraValidity;
            }
            set
            {
                cameraValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterCameraValidityChange();
                }
            }
        }
        [Tooltip("The rules to determine which colliders in the scene will activate the fade.")]
        [SerializeField]
        private RuleContainer collisionValidity;
        /// <summary>
        /// The rules to determine which colliders in the scene will activate the fade.
        /// </summary>
        public RuleContainer CollisionValidity
        {
            get
            {
                return collisionValidity;
            }
            set
            {
                collisionValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterCollisionValidityChange();
                }
            }
        }
        #endregion

        #region Fading Events
        [Header("Fading Events")]
        /// <summary>
        /// Emitted when the screen has faded completely.
        /// </summary>
        public UnityEvent Faded = new UnityEvent();
        /// <summary>
        /// Emitted when the screen has unfaded completely.
        /// </summary>
        public UnityEvent Unfaded = new UnityEvent();
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]

        [Tooltip("The container of the collider and collision logic.")]
        [SerializeField]
        private ObjectReference colliderContainer;
        /// <summary>
        /// The container of the collider and collision logic.
        /// </summary>
        public ObjectReference ColliderContainer
        {
            get
            {
                return colliderContainer;
            }
            protected set
            {
                colliderContainer = value;
            }
        }
        [Tooltip("The container of the camera overlay and fading logic.")]
        [SerializeField]
        private ObjectReference overlayContainer;
        /// <summary>
        /// The container of the camera overlay and fading logic.
        /// </summary>
        public ObjectReference OverlayContainer
        {
            get
            {
                return overlayContainer;
            }
            protected set
            {
                overlayContainer = value;
            }
        }
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private CollisionFaderConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public CollisionFaderConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="Source"/>.
        /// </summary>
        public virtual void ClearSource()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Source = default;
        }

        /// <summary>
        /// Clears <see cref="CameraValidity"/>.
        /// </summary>
        public virtual void ClearCameraValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            CameraValidity = default;
        }

        /// <summary>
        /// Clears <see cref="CollisionValidity"/>.
        /// </summary>
        public virtual void ClearCollisionValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            CollisionValidity = default;
        }

        /// <summary>
        /// Called after <see cref="Source"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSourceChange()
        {
            Configuration.SetupFollower();
        }

        /// <summary>
        /// Called after <see cref="CameraValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterCameraValidityChange()
        {
            Configuration.SetupFadeOverlay();
        }

        /// <summary>
        /// Called after <see cref="CollisionValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterCollisionValidityChange()
        {
            Configuration.SetupCollisionRule();
        }
    }
}