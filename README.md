<a id="inicio"></a>

<div align="center">

<img src="images/bosch-edc15-eeprom-tool-banner.png" alt="Bosch EDC15 EEPROM Tool: programa de Windows con tema claro y oscuro, mostrando el cÃ³digo de acceso, el estado del inmovilizador y el kilometraje de una EEPROM EDC15" width="100%">

# Bosch EDC15 EEPROM Tool â€” EspaÃ±ol

**Lee y edita la EEPROM 24C04 de las centralitas diÃ©sel Bosch EDC15: inmovilizador, kilometraje y cÃ³digo de acceso.**<br>
Herramienta para Windows destinada a centralitas VAG EDC15 de Audi, Volkswagen, SEAT y Å koda. Permite activar o desactivar el inmovilizador, leer y corregir el kilometraje, y leer o cambiar el cÃ³digo PIN de 5 dÃ­gitos en un archivo `.bin` de 512 bytes.

<p>
  <a href="https://github.com/muki01/Bosch_EDC15_EEPROM_Tool/stargazers"><img alt="Estrellas" height="28" src="https://img.shields.io/github/stars/muki01/Bosch_EDC15_EEPROM_Tool?style=flat&logo=github&logoColor=white&label=Estrellas&labelColor=1f2328&color=0891b2"></a>
  <a href="https://github.com/muki01/Bosch_EDC15_EEPROM_Tool/network/members"><img alt="Forks" height="28" src="https://img.shields.io/github/forks/muki01/Bosch_EDC15_EEPROM_Tool?style=flat&logo=github&logoColor=white&label=Forks&labelColor=1f2328&color=2563eb"></a>
  <a href="https://github.com/muki01/Bosch_EDC15_EEPROM_Tool/issues"><img alt="Incidencias" height="28" src="https://img.shields.io/github/issues/muki01/Bosch_EDC15_EEPROM_Tool?style=flat&logo=github&logoColor=white&label=Incidencias&labelColor=1f2328&color=6366f1"></a>
  <a href="LICENSE"><img alt="Licencia GPL-3.0" height="28" src="https://img.shields.io/badge/License-GPL--3.0-16a34a?style=flat&logo=opensourceinitiative&logoColor=white&labelColor=1f2328"></a>
  <a href="https://github.com/muki01/Bosch_EDC15_EEPROM_Tool/releases"><img alt="Ãšltima versiÃ³n" height="28" src="https://img.shields.io/github/v/release/muki01/Bosch_EDC15_EEPROM_Tool?style=flat&logo=github&logoColor=white&label=Versi%C3%B3n&labelColor=1f2328&color=9333ea"></a>
  <a href="https://github.com/muki01/Bosch_EDC15_EEPROM_Tool/actions/workflows/build.yml"><img alt="Estado de compilaciÃ³n" height="28" src="https://img.shields.io/github/actions/workflow/status/muki01/Bosch_EDC15_EEPROM_Tool/build.yml?style=flat&logo=githubactions&logoColor=white&label=Compilaci%C3%B3n&labelColor=1f2328"></a>
</p>

**[CaracterÃ­sticas](#caracteristicas) Â· [Capturas](#capturas) Â· [Centralitas compatibles](#centralitas-compatibles) Â· [Compilar](#compilar) Â· [Uso](#uso) Â· [Desarrollo](#desarrollo-a-medida)**

</div>

---

## Resumen

**Bosch EDC15 EEPROM Tool** abre un volcado de 512 bytes de una EEPROM 24C04 de una centralita de motor **Bosch EDC15** â€”montada en numerosos vehÃ­culos diÃ©sel de Audi, Volkswagen, SEAT y Å koda de finales de los aÃ±os noventa y principios de los 2000â€” y muestra el estado del inmovilizador, el kilometraje, el cÃ³digo PIN, el VIN y el identificador del inmovilizador.

Al modificar un dato, queda marcado como cambiado. Al guardar, la herramienta crea un archivo `.bin` nuevo y conserva intacto el original. No hace falta editar hexadecimal: la herramienta gestiona las posiciones, las copias duplicadas y las validaciones.

<a id="caracteristicas"></a>

## CaracterÃ­sticas

- ðŸ” **Inmovilizador** â€” actÃ­valo o desactÃ­valo; se escriben juntas las dos copias del dato.
- ðŸ”¢ **Kilometraje** â€” consulta el valor almacenado y corrÃ­gelo. Se actualizan las dos copias y se conservan los bits reservados.
- ðŸ”‘ **CÃ³digo PIN** â€” lee, copia o cambia el cÃ³digo de 5 dÃ­gitos (`0XXXX`) usado en la programaciÃ³n de llaves y adaptaciones.
- ðŸš— **Datos del vehÃ­culo** â€” muestra el VIN y el identificador del inmovilizador guardados en el volcado.
- ðŸ·ï¸ **Deshacer cambios** â€” cada valor modificado se puede restaurar por separado; **Deshacer todo** restaura todos los valores.
- âœ… **Validaciones** â€” rechaza archivos que no tengan 512 bytes y avisa si detecta datos inusuales, copias distintas o un cÃ³digo fuera de rango.
- â†©ï¸ **EdiciÃ³n segura** â€” solo escribe los valores que cambias, valida mientras escribes y no sobrescribe el original salvo que elijas expresamente ese archivo.
- ðŸŒ— **Tema claro y oscuro** â€” sigue el tema de Windows y cambia al instante.
- ðŸ–±ï¸ **Atajos** â€” arrastra el volcado a la ventana; `Ctrl+O` para abrir, `Ctrl+S` para guardar y `F1` para ver informaciÃ³n.

<a id="capturas"></a>

## Capturas

Las capturas alternan entre tema claro y oscuro segÃºn el tema de GitHub. La aplicaciÃ³n sigue la configuraciÃ³n de Windows.

<table>
<tr>
<td align="center" width="50%">
<picture><source media="(prefers-color-scheme: dark)" srcset="images/screenshots/dark/start.png"><img src="images/screenshots/light/start.png" alt="Ventana inicial de la herramienta antes de abrir un archivo" width="100%"></picture>
<br><b>Inicio</b><br><sub>Abre un archivo o arrÃ¡stralo a la ventana</sub>
</td>
<td align="center" width="50%">
<picture><source media="(prefers-color-scheme: dark)" srcset="images/screenshots/dark/edited.png"><img src="images/screenshots/light/edited.png" alt="Herramienta con valores modificados marcados" width="100%"></picture>
<br><b>EdiciÃ³n</b><br><sub>Los valores modificados se marcan y se pueden restaurar por separado</sub>
</td>
</tr>
<tr>
<td align="center">
<picture><source media="(prefers-color-scheme: dark)" srcset="images/screenshots/dark/invalid.png"><img src="images/screenshots/light/invalid.png" alt="Mensajes de validaciÃ³n del cÃ³digo PIN y el kilometraje" width="100%"></picture>
<br><b>ValidaciÃ³n</b><br><sub>La aplicaciÃ³n explica los datos incorrectos y bloquea el guardado</sub>
</td>
<td align="center">
<picture><source media="(prefers-color-scheme: dark)" srcset="images/screenshots/dark/about.png"><img src="images/screenshots/light/about.png" alt="Ventana de informaciÃ³n de Bosch EDC15 EEPROM Tool" width="100%"></picture>
<br><b>Acerca de</b><br><sub>Funciones de la herramienta y precauciones</sub>
</td>
</tr>
</table>

<a id="centralitas-compatibles"></a>

## Centralitas compatibles

La herramienta estÃ¡ diseÃ±ada para centralitas VAG EDC15 que utilicen una EEPROM 24C04 de 512 bytes. En estas unidades, las posiciones del inmovilizador, el kilometraje y el cÃ³digo PIN comparten la misma estructura.

| ParÃ¡metro | Compatibilidad |
| :-- | :-- |
| **Fabricante** | Bosch |
| **Familia de centralitas** | EDC15P, EDC15P+, EDC15VM+ (variantes VAG) |
| **VehÃ­culos** | Audi, Volkswagen, SEAT y Å koda |
| **Memoria** | EEPROM serie 24C04, 512 bytes |

> [!IMPORTANT]
> **Comprueba que el volcado es compatible.** El archivo debe medir exactamente **512 bytes** (24C04). Si la herramienta indica que no reconoce el inmovilizador o el cÃ³digo PIN no tiene el formato `0XXXX`, o muestra el VIN como Â«No encontradoÂ», probablemente se trata de otra estructura de centralita: no guardes el archivo. No son compatibles las EDC15 con EEPROM **95040 / 95080 / 95160** ni las EDC15 de otras marcas (Renault, Volvo, Ford, etc.).

<details>
<summary><b>Estructura de la EEPROM (detalles tÃ©cnicos)</b></summary>

<br>

Las posiciones corresponden al volcado de 512 bytes. Cada valor editable aparece dos veces: la herramienta lee la primera copia y escribe ambas.

| Valor | Principal | Copia | Notas |
| :-- | :-- | :-- | :-- |
| CÃ³digo PIN | `0x12Eâ€“0x12F` | `0x160â€“0x161` | Little-endian; se muestra como `0XXXX` |
| Inmovilizador | `0x1B0` | `0x1DE` | `0x73` = activado, `0x60` = desactivado |
| Kilometraje | `0x1BFâ€“0x1C2` | `0x1EDâ€“0x1F0` | 28 bits, valor = km Ã— 100; el nibble alto del Ãºltimo byte estÃ¡ reservado |
| VIN | `0x140` | â€” | 17 caracteres ASCII; solo lectura |
| Identificador del inmovilizador | `0x131` | â€” | 14 caracteres; solo lectura |

</details>

<a id="compilar"></a>

## Compilar desde el cÃ³digo fuente

Requisitos: Windows con [.NET SDK](https://dotnet.microsoft.com/download) 9 o posterior, o Visual Studio 2022 (17.12+) con la carga de trabajo *Desarrollo de escritorio de .NET*. El programa se compila para **.NET Framework 4.8**, incluido en Windows 10 y 11, asÃ­ que quien lo use no necesita instalarlo.

```bash
git clone https://github.com/dewasha40/Bosch_EDC15_EEPROM_Tool-spanish.git
cd Bosch_EDC15_EEPROM_Tool-spanish

dotnet build -c Release          # compilar
dotnet test                      # ejecutar las pruebas
dotnet run --project src/Edc15EepromTool
```

Para generar el ejecutable:

```bash
dotnet publish src/Edc15EepromTool -c Release -o publish
```

El resultado es `publish/EDC15 EEPROM Tool.exe`, un Ãºnico archivo de unos 110 KB.

### Estructura del proyecto

```text
Bosch_EDC15_EEPROM_Tool-spanish/
â”œâ”€â”€ src/Edc15EepromTool/
â”‚   â”œâ”€â”€ Core/              Edc15Eeprom: lectura y escritura del volcado
â”‚   â”œâ”€â”€ ViewModels/        Estado y comandos de la ventana
â”‚   â”œâ”€â”€ Themes/            Paletas claras y oscuras y estilos
â”‚   â””â”€â”€ MainWindow.xaml    Interfaz de usuario
â”œâ”€â”€ tests/                 Pruebas unitarias con los volcados de ejemplo
â””â”€â”€ Example EEPROM Files/  Volcados de referencia
```

<a id="uso"></a>

## Uso

1. **Abrir** â€” arrastra el volcado de 512 bytes a la ventana o pulsa **Abrir archivo**.
2. **Revisar** â€” comprueba el inmovilizador, el kilometraje, el cÃ³digo PIN y los datos del vehÃ­culo. Se avisarÃ¡ si algo parece inusual.
3. **Editar** â€” cambia el inmovilizador, escribe un kilometraje o un cÃ³digo PIN. Los valores modificados quedan marcados y se pueden restaurar por separado.
4. **Guardar** â€” pulsa **Guardar archivo** para crear otro archivo `.bin`.

## Colaborar

Se agradecen informes de centralitas probadas, errores, correcciones y mejoras de documentaciÃ³n. Lee primero la [guÃ­a para contribuir](CONTRIBUTING.md) y el [cÃ³digo de conducta](CODE_OF_CONDUCT.md).

**Â¿Lo has probado con tu centralita?** Abre un [informe de compatibilidad](https://github.com/dewasha40/Bosch_EDC15_EEPROM_Tool-spanish/issues/new/choose) e incluye la referencia Bosch y el vehÃ­culo. No publiques volcados: contienen el VIN, el identificador del inmovilizador y el cÃ³digo PIN del vehÃ­culo. Los problemas de seguridad se deben comunicar segÃºn la [polÃ­tica de seguridad](SECURITY.md), no en una incidencia pÃºblica.

## Proyectos relacionados

La herramienta forma parte de una familia de proyectos automotrices de cÃ³digo abierto de [Muki](https://github.com/muki01).

| Proyecto | DescripciÃ³n |
| :-- | :-- |
| [BMW I-Bus / K-Bus Firmware](https://github.com/muki01/BMW_IBus_KBus) | Control desde el mÃ³vil y funciones de iluminaciÃ³n con el mando para BMW E46, ESP32 y Arduino. |
| [OBD2 K-Line Reader](https://github.com/muki01/OBD2_K-line_Reader) | DiagnÃ³stico para vehÃ­culos K-Line (ISO 9141-2, KWP2000) con panel web para ESP32, ESP8266 y Arduino. |
| [VAG KW1281](https://github.com/muki01/VAG_KW1281) | DiagnÃ³stico KW1281 para VW, Audi, Å koda y SEAT: datos de ECU, grupos de mediciÃ³n y cÃ³digos de averÃ­a. |
| [Biblioteca OBD2 K-Line](https://github.com/muki01/OBD2_KLine_Library) | DiagnÃ³stico K-Line mediante ISO 9141-2, KWP2000, KW1281, DS2 y KW82. |
| [Biblioteca OBD2 CAN Bus](https://github.com/muki01/OBD2_CAN_Bus_Library) | DiagnÃ³stico OBD-II por ISO 15765-4 con el controlador CAN integrado del ESP32. |
| **Bosch EDC15 EEPROM Tool** | Editor del inmovilizador, kilometraje y cÃ³digo PIN para EEPROM 24C04 de Bosch EDC15. |

<a id="desarrollo-a-medida"></a>

## Desarrollo a medida

DiseÃ±o herramientas de diagnÃ³stico, firmware y hardware para automociÃ³n. Puedo ayudar con un producto completo o con la capa de comunicaciÃ³n.

| Servicio | Detalles |
| :-- | :-- |
| **ImplementaciÃ³n de protocolos** | BMW I/K-Bus, K-Line (ISO 9141-2 / KWP2000), CAN / UDS, VAG KW1281 y protocolos especÃ­ficos de fabricante |
| **ComunicaciÃ³n y anÃ¡lisis de ECU** | Captura de bus, decodificaciÃ³n de paquetes, control de mÃ³dulos y estructuras EEPROM/flash |
| **Acceso de seguridad a ECU** | Algoritmos seed-key y rutinas de desbloqueo para KWP2000 / UDS |
| **Firmware integrado** | Arduino, ESP32, ESP8266, STM32 y Raspberry Pi Pico |
| **Hardware a medida** | Interfaces de diagnÃ³stico, shields y PCB segÃºn los requisitos |
| **Aplicaciones de escritorio y mÃ³viles** | Windows, Android, iOS y web para leer, registrar y editar datos del vehÃ­culo |

## Contacto

| Canal | DirecciÃ³n |
| :-- | :-- |
| ðŸ“§ **Correo** | [muksin.muksin04@gmail.com](mailto:muksin.muksin04@gmail.com) |
| ðŸ’¼ **LinkedIn** | [linkedin.com/in/muksin-muksin](https://www.linkedin.com/in/muksin-muksin/) |
| ðŸ™ **GitHub** | [@muki01](https://github.com/muki01) |

## Apoyar el proyecto

Si este proyecto te ha resultado Ãºtil, puedes apoyar su desarrollo:

- [Buy Me a Coffee](https://www.buymeacoffee.com/muki01)
- [Donar con PayPal](https://www.paypal.com/donate/?hosted_button_id=SAAH5GHAH6T72)
- [GitHub Sponsors](https://github.com/sponsors/muki01)

## Historial de estrellas

<a href="https://star-history.com/#muki01/Bosch_EDC15_EEPROM_Tool&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=muki01/Bosch_EDC15_EEPROM_Tool&type=Date&theme=dark">
    <img alt="GrÃ¡fico del historial de estrellas de Bosch EDC15 EEPROM Tool" src="https://api.star-history.com/svg?repos=muki01/Bosch_EDC15_EEPROM_Tool&type=Date" width="100%">
  </picture>
</a>

## Aviso legal y de uso

> [!WARNING]
> Esta herramienta se ofrece **tal cual**, para fines educativos y de reparaciÃ³n de vehÃ­culos. Editar datos de una ECU conlleva riesgos y un error puede impedir que el vehÃ­culo arranque. **Conserva siempre una copia** del volcado original de 512 bytes. Corrige el kilometraje Ãºnicamente para reflejar el cambio de cuadro de instrumentos o de centralita; alterar el kilometraje para engaÃ±ar a un comprador es ilegal en la mayorÃ­a de paÃ­ses. El autor no se responsabiliza de daÃ±os en vehÃ­culos, centralitas o equipos.

## Licencia

Publicado bajo la [GNU General Public License v3.0](LICENSE).

- Puedes usar, estudiar, modificar y compartir esta herramienta.
- Si la distribuyes, por sÃ­ sola o como parte de un producto, debes ofrecer el cÃ³digo fuente completo bajo la misma licencia.

Para integrar la herramienta en un producto comercial de cÃ³digo cerrado, existe una licencia comercial independiente. Contacta con el autor.

Copyright Â© 2026 Muksin Muksin.

---

<div align="center">

TraducciÃ³n al espaÃ±ol del proyecto de [**Muki**](https://github.com/muki01) Â· [Repositorio original](https://github.com/muki01/Bosch_EDC15_EEPROM_Tool)

<sub>Bosch EDC15 Â· EEPROM 24C04 Â· inmovilizador Â· kilometraje Â· cÃ³digo PIN Â· VAG Â· Audi Â· VW Â· SEAT Â· Å koda Â· ECU diÃ©sel Â· WPF Â· .NET</sub>

**[â¬† Volver al principio](#inicio)**

</div>

