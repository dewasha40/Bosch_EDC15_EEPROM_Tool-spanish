# Política de seguridad

Esta herramienta modifica el estado del inmovilizador, el código PIN y el kilometraje almacenados en la EEPROM de una centralita de motor. Por eso, tratamos seriamente cualquier informe de seguridad.

## Versiones compatibles

Las correcciones de seguridad se aplican al código más reciente de la rama `main` y a la versión publicada más reciente.

## Cómo informar de una vulnerabilidad

Si encuentras un problema de seguridad, **no abras una incidencia pública**.

Escribe a **muksin.muksin04@gmail.com** o utiliza el [formulario privado para vulnerabilidades](https://github.com/dewasha40/Bosch_EDC15_EEPROM_Tool-spanish/security/advisories/new). Incluye:

- Descripción del problema y su posible impacto.
- Pasos para reproducirlo (versión de la herramienta, Windows y tipo de ECU).
- Una posible corrección, si la tienes.

**No envíes el volcado completo de la EEPROM** salvo que sea necesario para reproducir el problema. Si lo es, sustituye primero el VIN y el identificador del inmovilizador o consúltanos para acordar un modo privado de compartirlo.

Responderemos lo antes posible. Si lo deseas, incluiremos tu reconocimiento en las notas de la versión.

## Descargas

- Descarga el programa desde la página de [versiones publicadas](https://github.com/muki01/Bosch_EDC15_EEPROM_Tool/releases) del proyecto original. Las copias de otros sitios podrían estar modificadas.
- El ejecutable no está firmado digitalmente, por lo que Windows SmartScreen podría mostrar un aviso la primera vez. También puedes compilarlo desde el código fuente siguiendo el README.

## Recomendaciones

- Conserva siempre el volcado original. La herramienta propone un nombre nuevo al guardar, pero la opción más segura es guardar una copia de seguridad en otra unidad.
- Un volcado EEPROM contiene el VIN, el identificador del inmovilizador y el código PIN de un vehículo real. Trátalo como una llave y no lo publiques en incidencias ni foros.
- Usa la herramienta solo en vehículos propios o para los que tengas autorización, y respeta la legislación local. Modificar el kilometraje para engañar a un comprador es ilegal en la mayoría de países.

