# Umbraco Property Editor Template

<img align="right" src="images/vv-blueprint-icon.png" width="180" height="180" alt="The Vokseværk ‘fire-heart’ logo in light blue on a blueprint-style blue background with vertical, horizontal, diagonal and circular grid-lines" />

This is our Blueprint Project for an Umbraco Property Editor.

## Process

Click the **Use this template** button to create a new copy of this repository
in your own account. Then clone that new repository down to your local machine
and get started:

- [ ] Find the `src/package.ent` file and change the constants in there
- [ ] You may want to change a few things in the `package.xml` and `manifest.xml` files as well
- [ ] Look for `TODO`, `EDITOR_NAME` and `EDITOR_ALIAS` in various files and change accordingly
- [ ] Edit/add/remove files in the `src/` folder and update the files section in the
`package.xml` file
- [ ] Edit the `PropertyConverter(V[78])?.cs` files as well
- [ ] Edit this README to describe your new property editor :)
- [ ] Build and publish your package!


## Developing & Building

### Umbraco Package (for Umbraco 7 or 8)

On macOS you can run the `build.sh` script from the terminal, which will
build a ZIP file in the `dist` folder that is installable from
Umbraco 8's _Packages_ section or Umbraco 7's _Developer > Packages_ section.

The build script versions the files so it's easier to test the package inside
an Umbraco installation by uninstalling the existing version and then
installing a new build. Existing data-types keep their data as long as their
alias and/or storage type isn't changed.

To update the version number, increment the `packageVersion` entity in the
`src/package.ent` file.

### Nuget Package (for Umbraco 10+)

The `nuget-build-sh` makes use of the `nuget` CLI (so you'll need to have [.NET][NET] installed)
to build a `.nupkg` file, ready for uploading to [nuget.org][NUGET].
If you're using [Nova] you can use the supplied `Nuget v10` *Build* task; otherwise you should
make sure to supply the `UMB_VERSION` environment variable, e.g.:

```bash
# In the project's root directory
> UMB_VERSION=v10 nuget-build.sh
```

To update the version number, increment the `packageVersionV10` entity in the
`src/package.ent` file.



[OURPKG]: https://our.umbraco.com/member/profile/packages/
[Nova]: https://nova.app
[NET]: https://dot.net
[NUGET]: https://nuget.org
