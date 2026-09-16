@echo off

:: 1. Configura os caminhos
set "origem=C:\Users\Smitop\Desktop\CSharp_Foundation"
set "destino=G:\My Drive\Lucas\Cursos\CSharp_Foundation"

echo Iniciando backup inteligente da pasta...

:: 2. Executa o robocopy (Substituindo o xcopy)
:: /E   - Copia subpastas (inclusive vazias)
:: /XO  - Exclui arquivos "Older" (Não copia se o destino for igual ou mais novo que a origem)
:: /R:3 - Tenta 3 vezes em caso de erro (evita travar o script)
:: /W:5 - Espera 5 segundos entre tentativas
:: /MT  - (Opcional) Usa multi-threading para ser mais rapido
robocopy "%origem%" "%destino%" /E /XO /R:3 /W:5

echo.
echo Concluido! Apenas os arquivos novos ou alterados foram sincronizados.
pause