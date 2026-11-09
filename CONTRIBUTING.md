# Cómo contribuir

Gracias por colaborar. Cada centralita probada, informe de error, corrección e idea ayuda a mejorar esta herramienta para quienes trabajan con unidades EDC15.

Este proyecto sigue el [Código de conducta](CODE_OF_CONDUCT.md). Al participar, aceptas respetarlo.

## Formas de colaborar

| | |
|---|---|
| **Informar de una ECU probada** | Indica la referencia Bosch (por ejemplo, `0281010xxx`) y el vehículo, y explica si la herramienta funcionó. |
| **Informar de un error** | Describe qué hiciste, qué esperabas y qué ocurrió. |
| **Proponer una mejora** | Explica qué tarea de taller facilitaría. |
| **Enviar código** | Correcciones, compatibilidad con otras variantes EDC15 o mejoras de interfaz. |
| **Mejorar la documentación** | Aclaraciones, correcciones y traducciones del README. |

## Informar de errores

Antes de abrir una incidencia, busca en las [incidencias existentes](https://github.com/dewasha40/Bosch_EDC15_EEPROM_Tool-spanish/issues) y selecciona el formulario adecuado en la página para [crear una incidencia](https://github.com/dewasha40/Bosch_EDC15_EEPROM_Tool-spanish/issues/new/choose): **Error**, **Compatibilidad de ECU** o **Solicitud de mejora**. Incluye:

- La versión de la herramienta (aparece en la barra de título).
- La versión de Windows.
- La ECU: referencia Bosch, versión de software y vehículo.
- Lo que mostró la herramienta: inmovilizador, kilometraje, código PIN, VIN y avisos.
- Los pasos para reproducir el problema.

> [!IMPORTANT]
> **No adjuntes volcados de EEPROM públicamente.** Incluyen el VIN, el identificador del inmovilizador y el código PIN de un vehículo real. Si se necesita el volcado para reproducir un problema, ofrece enviarlo de forma privada o sustituye antes esos datos.

Si encuentras un problema de seguridad, sigue la [Política de seguridad](SECURITY.md) y comunícalo de forma privada.

## Flujo de desarrollo

1. Haz un fork del repositorio y crea una rama basada en `main`:
   ```bash
   git checkout -b feature/mi-mejora
   ```
2. Haz cambios concretos y acotados: una corrección o función por solicitud de cambios.
3. Ejecuta las pruebas y comprueba que la compilación no genere avisos:
   ```bash
   dotnet build -c Release
   dotnet test
   ```
4. Añade una prueba si cambias la lectura o escritura del volcado. Las pruebas de `tests/` comparan cada modificación byte a byte con los archivos de ejemplo.
5. Usa un mensaje de confirmación claro, por ejemplo: `Avisar cuando difieran las copias del código PIN`.
6. Sube la rama y abre una solicitud de cambios contra `main`. La plantilla pregunta qué has cambiado y en qué ECU lo has probado. GitHub Actions compila y prueba el proyecto automáticamente.

## Guía de estilo

- Sigue el estilo del archivo que edites: nombres, sangría y cantidad de comentarios.
- Mantén separadas las capas: `Core/Edc15Eeprom.cs` lee y escribe bytes sin código de interfaz; `ViewModels/` contiene el estado de la ventana; XAML solo lo muestra.
- Cada valor del volcado está duplicado. Lee la primera copia, escribe ambas y no cambies bytes que el usuario no haya editado.
- En la solicitud de cambios, indica la fuente de las nuevas posiciones: documentación, un volcado documentado o una ECU probada.
- Los textos visibles para el usuario de esta versión deben estar en español, ser breves y claros.

## Licencia

Al contribuir, aceptas que tus aportaciones se publiquen bajo la [GNU General Public License v3.0](LICENSE) y que el autor también pueda ofrecerlas bajo una licencia comercial.

