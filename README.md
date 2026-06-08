# AvaloniaApplication7 - wizualizacja procent -> ocena

Aplikacja desktopowa w **Avalonia UI (MVVM)**, ktora pokazuje zaleznosc miedzy procentem rozwiazanych zadan a ocena.

Repozytorium zawiera teraz takze wariant webowy (WebAssembly) w katalogu `AvaloniaApplication7.Web`.

## Co robi aplikacja

- Osi `X` odpowiada procent (`p_min` do `p_max`).
- Osi `Y` odpowiada ocena (`3` do `5`).
- Rysowany jest odcinek od punktu `(p_min, 3)` do `(p_max, 5)`.
- Czerwony punkt pokazuje aktualny wynik studenta (`StudentPercent`) oraz obliczona ocene.

## Uruchomienie

```powershell
dotnet restore .\AvaloniaApplication7.sln
dotnet run --project .\AvaloniaApplication7\AvaloniaApplication7.csproj
```

## Budowanie

```powershell
dotnet build .\AvaloniaApplication7.sln
```

## Wersja webowa (WASM)

```powershell
dotnet build .\AvaloniaApplication7.Web\GradeScaleApp.Browser\GradeScaleApp.Browser.csproj
dotnet publish .\AvaloniaApplication7.Web\GradeScaleApp.Browser\GradeScaleApp.Browser.csproj -c Release
```

Artefakty statyczne znajdziesz w:

`AvaloniaApplication7.Web/GradeScaleApp.Browser/bin/Release/net9.0-browser/publish/wwwroot`

## GitHub Pages

Workflow do publikacji jest w pliku:

`.github/workflows/deploy-avalonia-web.yml`

Po pushu na galezi `main` workflow buduje `GradeScaleApp.Browser` i publikuje wynik na GitHub Pages.

