# Class CollisionFaderFacade

The public interface for the CollisionFader prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [Faded]
  * [Unfaded]
* [Properties]
  * [CameraValidity]
  * [ColliderContainer]
  * [CollisionValidity]
  * [Configuration]
  * [OverlayContainer]
  * [Source]
* [Methods]
  * [ClearCameraValidity()]
  * [ClearCollisionValidity()]
  * [ClearSource()]
  * [OnAfterCameraValidityChange()]
  * [OnAfterCollisionValidityChange()]
  * [OnAfterSourceChange()]

## Details

##### Inheritance

* System.Object
* CollisionFaderFacade

##### Namespace

* [Tilia.Visuals.CollisionFader]

##### Syntax

```
public class CollisionFaderFacade : MonoBehaviour
```

### Fields

#### Faded

##### Declaration

```
public UnityEvent Faded
```

#### Unfaded

Emitted when the screen has unfaded completely.

##### Declaration

```
public UnityEvent Unfaded
```

### Properties

#### CameraValidity

The rules to determine which scene cameras to apply the overlay to.

##### Declaration

```
public RuleContainer CameraValidity { get; set; }
```

#### ColliderContainer

The container of the collider and collision logic.

##### Declaration

```
public ObjectReference ColliderContainer { get; protected set; }
```

#### CollisionValidity

The rules to determine which colliders in the scene will activate the fade.

##### Declaration

```
public RuleContainer CollisionValidity { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public CollisionFaderConfigurator Configuration { get; protected set; }
```

#### OverlayContainer

The container of the camera overlay and fading logic.

##### Declaration

```
public ObjectReference OverlayContainer { get; protected set; }
```

#### Source

The source for the internal Collider to follow.

##### Declaration

```
public GameObject Source { get; set; }
```

### Methods

#### ClearCameraValidity()

Clears [CameraValidity].

##### Declaration

```
public virtual void ClearCameraValidity()
```

#### ClearCollisionValidity()

Clears [CollisionValidity].

##### Declaration

```
public virtual void ClearCollisionValidity()
```

#### ClearSource()

Clears [Source].

##### Declaration

```
public virtual void ClearSource()
```

#### OnAfterCameraValidityChange()

Called after [CameraValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterCameraValidityChange()
```

#### OnAfterCollisionValidityChange()

Called after [CollisionValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterCollisionValidityChange()
```

#### OnAfterSourceChange()

Called after [Source] has been changed.

##### Declaration

```
protected virtual void OnAfterSourceChange()
```

[Tilia.Visuals.CollisionFader]: README.md
[CollisionFaderConfigurator]: CollisionFaderConfigurator.md
[CameraValidity]: CollisionFaderFacade.md#CameraValidity
[CollisionValidity]: CollisionFaderFacade.md#CollisionValidity
[Source]: CollisionFaderFacade.md#Source
[CameraValidity]: CollisionFaderFacade.md#CameraValidity
[CollisionValidity]: CollisionFaderFacade.md#CollisionValidity
[Source]: CollisionFaderFacade.md#Source
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[Faded]: #Faded
[Unfaded]: #Unfaded
[Properties]: #Properties
[CameraValidity]: #CameraValidity
[ColliderContainer]: #ColliderContainer
[CollisionValidity]: #CollisionValidity
[Configuration]: #Configuration
[OverlayContainer]: #OverlayContainer
[Source]: #Source
[Methods]: #Methods
[ClearCameraValidity()]: #ClearCameraValidity
[ClearCollisionValidity()]: #ClearCollisionValidity
[ClearSource()]: #ClearSource
[OnAfterCameraValidityChange()]: #OnAfterCameraValidityChange
[OnAfterCollisionValidityChange()]: #OnAfterCollisionValidityChange
[OnAfterSourceChange()]: #OnAfterSourceChange
