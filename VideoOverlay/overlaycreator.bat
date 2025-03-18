@echo off

set mode=%1
set name=%2
cls

:::     ,---,.                                           ,---,                         
:::   ,'  .' |                                          '  .' \        ,--,            
::: ,---.'   |   ,---.    __  ,-.                      /  ;    '.    ,--.'|    __  ,-. 
::: |   |   .'  '   ,'\ ,' ,'/ /|  ,----._,.          :  :       \   |  |,   ,' ,'/ /| 
::: :   :  :   /   /   |'  | |' | /   /  ' /   ,---.  :  |   /\   \  `--'_   '  | |' | 
::: :   |  |-,.   ; ,. :|  |   ,'|   :     |  /     \ |  :  ' ;.   : ,' ,'|  |  |   ,' 
::: |   :  ;/|'   | |: :'  :  /  |   | .\  . /    /  ||  |  ;/  \   \'  | |  '  :  /   
::: |   |   .''   | .; :|  | '   .   ; ';  |.    ' / |'  :  | \  \ ,'|  | :  |  | '    
::: '   :  '  |   :    |;  : |   '   .   . |'   ;   /||  |  '  '--'  '  : |__;  : |    
::: |   |  |   \   \  / |  , ;    `---`-'| |'   |  / ||  :  :        |  | '.'|  , ;    
::: |   :  \    `----'   ---'     .'__/\_: ||   :    ||  | ,'        ;  :    ;---'     
::: |   | ,'                      |   :    : \   \  / `--''          |  ,   /          
::: `----'                         \   \  /   `----'                  ---`-'           
:::                                  `--`-'                                      
:::                       ForgeAirVideo Overlay Creator Script v1.0
:::                          Written by @chocolateadventurouz       
::: -----------------------------------------------------------------------------------------       
::: Usage:
:::         overlaycreator create [overlayname]
::: -----------------------------------------------------------------------------------------       
for /f "delims=: tokens=*" %%A in ('findstr /b ::: "%~f0"') do @echo(%%A

if [%mode%] == [] echo [-] No arguments passed. Exiting... && exit /b
if [%name%] == [] echo [-] No overlay name passed. Exiting... && exit /b
if "%mode%" NEQ  "create" echo [-] No proper argument passed. Exiting... && exit /b
echo [!] Creating video overlay '%name%'...
mkdir %name%

echo [!] Creating overlay.json...
echo ^{^"overlay^": [^
    {^
        ^"name^": ^"%name%^",^
        ^"description^": ^"%name% video overlay^",^
        ^"author^": ^"%USERNAME%^",^
        ^"screenshot^": ^"^",^
        ^"version^": ^"1.0^",^
        ^"overlayScript^": ^"overlay.html^"^
    }^
]^} > %name%/overlay.json

echo [!] Creating entry overlay file...
echo "<!DOCTYPE html><html><head><body><script></script></body></head></html>" > %name%/overlay.html

echo [!] Adding library...

mkdir "%name%/lib"

xcopy /y "lib" "%name%/lib" 

echo [+] Success
exit /b