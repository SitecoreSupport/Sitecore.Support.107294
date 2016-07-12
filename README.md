# Sitecore.Support.107294

A custom data in the `FormsAuthenticationTicket.UserData` may conflict with the `User.RuntimeSettings`. 

## Main

This repository contains Sitecore Patch #107294, which rolls back fixes #365855 and #441004 for a Virtual User feature.

## Deployment

To apply the patch, perform the following steps on both CM and CD servers:

1. Place the `Sitecore.Support.107294.dll` assembly into the `\bin` directory.
2. Place the `z.Sitecore.Support.107294.config` file into the `\App_Config\Include` directory.

## Content 

Sitecore Patch includes the following files:

1. `\bin\Sitecore.Support.107294.dll`
2. `\App_Config\Include\z.Sitecore.Support.107294.config`

## License

This patch is licensed under the [Sitecore Corporation A/S License](./LICENSE).

## Download

Downloads are available via [GitHub Releases](https://github.com/SitecoreSupport/Sitecore.Support.107294/releases).