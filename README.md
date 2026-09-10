# StatusRespondingRelationProvidence

MelonLoader mod for ChilloutVR. A single Harmony postfix on `MetaPort.Start` that sets `matureContentAllowed` to true.

## Build

The project references `0Harmony.dll`, `MelonLoader.dll` and the game assemblies from a Steam install of ChilloutVR. Adjust the hint paths in the `.csproj` if yours lives elsewhere, then:

```sh
dotnet build -c Release
```

## Install

Copy `bin/Release/StatusRespondingRelationProvidence.dll` into `ChilloutVR/Mods/`.
