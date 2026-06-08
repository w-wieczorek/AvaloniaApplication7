# AvaloniaApplication7.Web

Wersja cross-platform aplikacji z targetem przegladarkowym (WebAssembly) i desktopowym.

## Projekty

- `GradeScaleApp` - wspolna logika MVVM i widoki.
- `GradeScaleApp.Browser` - host WebAssembly (do GitHub Pages).
- `GradeScaleApp.Desktop` - host desktop.

## Uruchomienie lokalne (desktop)

```powershell
dotnet run --project .\AvaloniaApplication7.Web\GradeScaleApp.Desktop\GradeScaleApp.Desktop.csproj
```

## Uruchomienie lokalne (web)

```powershell
dotnet run --project .\AvaloniaApplication7.Web\GradeScaleApp.Browser\GradeScaleApp.Browser.csproj
```

## Publikacja artefaktu web

```powershell
dotnet publish .\AvaloniaApplication7.Web\GradeScaleApp.Browser\GradeScaleApp.Browser.csproj -c Release
```

Wynik publikacji znajduje sie w:

`AvaloniaApplication7.Web/GradeScaleApp.Browser/bin/Release/net9.0-browser/publish/wwwroot`

