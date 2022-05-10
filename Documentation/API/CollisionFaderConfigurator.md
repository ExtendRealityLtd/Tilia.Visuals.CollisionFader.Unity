# Class CollisionFaderConfigurator

Sets up the CollisionFader prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [CollisionProxy]
  * [Facade]
  * [FadeOverlay]
  * [SourceFollower]
* [Methods]
  * [NotifyFaded()]
  * [NotifyUnfaded()]
  * [OnEnable()]
  * [SetupCollisionRule()]
  * [SetupFadeOverlay()]
  * [SetupFollower()]

## Details

##### Inheritance

* System.Object
* CollisionFaderConfigurator

##### Namespace

* [Tilia.Visuals.CollisionFader]

##### Syntax

```
public class CollisionFaderConfigurator : MonoBehaviour
```

### Properties

#### CollisionProxy

The linked CollisionNotifierEventProxyEmitter to set the valid collisions rule on.

##### Declaration

```
public CollisionNotifierEventProxyEmitter CollisionProxy { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public CollisionFaderFacade Facade { get; protected set; }
```

#### FadeOverlay

The linked CameraColorOverlay to use to fade the camera.

##### Declaration

```
public CameraColorOverlay FadeOverlay { get; protected set; }
```

#### SourceFollower

The linked ObjectFollower to attach the source to.

##### Declaration

```
public ObjectFollower SourceFollower { get; protected set; }
```

### Methods

#### NotifyFaded()

Emits the Facade.Faded event.

##### Declaration

```
public virtual void NotifyFaded()
```

#### NotifyUnfaded()

Emits the Facade.Unfaded event.

##### Declaration

```
public virtual void NotifyUnfaded()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### SetupCollisionRule()

Sets up the [CollisionProxy] with the relevant collision rules.

##### Declaration

```
public virtual void SetupCollisionRule()
```

#### SetupFadeOverlay()

Sets up the [FadeOverlay] with the relevant scene camera rules.

##### Declaration

```
public virtual void SetupFadeOverlay()
```

#### SetupFollower()

Sets up the [SourceFollower] component with the relevant source.

##### Declaration

```
public virtual void SetupFollower()
```

[Tilia.Visuals.CollisionFader]: README.md
[CollisionFaderFacade]: CollisionFaderFacade.md
[CollisionProxy]: CollisionFaderConfigurator.md#CollisionProxy
[FadeOverlay]: CollisionFaderConfigurator.md#FadeOverlay
[SourceFollower]: CollisionFaderConfigurator.md#SourceFollower
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[CollisionProxy]: #CollisionProxy
[Facade]: #Facade
[FadeOverlay]: #FadeOverlay
[SourceFollower]: #SourceFollower
[Methods]: #Methods
[NotifyFaded()]: #NotifyFaded
[NotifyUnfaded()]: #NotifyUnfaded
[OnEnable()]: #OnEnable
[SetupCollisionRule()]: #SetupCollisionRule
[SetupFadeOverlay()]: #SetupFadeOverlay
[SetupFollower()]: #SetupFollower
