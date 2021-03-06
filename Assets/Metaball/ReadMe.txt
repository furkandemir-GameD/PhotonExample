------------------------------
SkinnedMetaballBuilder
version 1.12
Copyright © 2015 Junk Games

homepage (tutorials, references, videos and support)
[English]
http://nkdtr.hatenablog.com/entry/2015/06/05/125027
[Japanese]
http://nkdtr.hatenablog.com/entry/2015/06/11/000322
------------------------------

Thank you for buying SkinnedMetaballBuilder!

Please refer the homepage for details.


Quick Start:
http://nkdtr.hatenablog.com/entry/2015/06/10/234538
https://youtu.be/J35LcdCPhKc

1. Drag and drop "Metaball/Prefabs/SkinnedSeed" into your scene.

2. Choose "SkinnedSeed/SourceTree" in hierarchy.

3. "Ctrl+Shift+E" or "Command+Shift+E" to create a new metaball node.

4. Move it, modify its "base radius" as you like.

5. Repeat 3-4 (Changing node selection to be the parent of new node).
The hierarchy under "SourceTree" is reflected into the "skeleton" generated later.

6. "Ctrl+Shift+R" or "Command+Shift+R" to generate mesh.

7. Select some node under "SkinnedSeed/BoneRoot",
and rotate it to confirm that your mesh transforms.

8. "Metaball->SavePrefab" to save full prefab
or "Metaball->SaveMesh" to save mesh only.


-------------------
versioni history
-------------------
1.12
-Add vertex color option (with blending between nodes)

1.11
-Fixed Issue : Shortcut "Ctrl/Command+Shift+E"(create node / draw with brush) didn't work

1.10
-Add "incremental modeling" mode:
 -Sphere, Box primitives with scale and rotation
 -Add/Subtract metaball shape with low rate of increasing the mesh creation cost (no GameObject spawned).
 -BUT NO SKINNING, NO METABALL MOVE
-"Incremental Modeling" version of "Dungeon" sample
 -Digging without spawning GameObjects
 -Two "Weapons" implemented

1.02
- Added "auto grid size" option

1.01
- Removed unused asset
- Fixed bad behavior (by the version of Unity)

1.0
- First released version.

