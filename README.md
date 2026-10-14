# StatusRespondingRelationProvidence

MelonLoader mod for ChilloutVR. a single Harmony postfix on `MetaPort.Start` that sets `matureContentAllowed` to true.

## build

the project references `0Harmony.dll`, `MelonLoader.dll` and the game assemblies from a Steam install of ChilloutVR. adjust the hint paths in the `.csproj` if yours lives elsewhere, then:

```sh
dotnet build -c Release
```

## install

copy `bin/Release/StatusRespondingRelationProvidence.dll` into `ChilloutVR/Mods/`.
