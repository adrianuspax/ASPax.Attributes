@echo off
echo Step 0/7: If Unity is running, it will be closed!
tasklist | find /i "Unity.exe" > nul
if %errorlevel% == 0 (
    echo Closing Unity...
    taskkill /F /IM Unity.exe
) else (
    echo Unity is not running.
)

echo Step 1/7: Deleting Logs Folder...
if exist "Logs" (
    rmdir /s /q "Logs"
    echo Logs Folder Deleted.
) else (
    echo Logs Folder is not found!
)

echo Step 2/7: Deleting obj Folder...
if exist "obj" (
    rmdir /s /q "obj"
    echo obj Folder Deleted.
) else (
    echo obj Folder is not found!
)

echo Step 3/7: Deleting Temp Folder...
if exist "Temp" (
    rmdir /s /q "Temp"
    echo Temp Folder Deleted.
) else (
    echo Temp Folder is not found!
)

echo Step 4/7: Deleting Library Folder...
if exist "Library" (
    rmdir /s /q "Library"
    echo Library Folder Deleted.
) else (
    echo Library Folder is not found!
)

echo Step 5/7: Deleting .sln...
del /q *.sln
echo .sln files deleteds.

echo Step 6/7: Deleting .csproj files...
del /q *.csproj
echo .csproj files deleteds.

echo Step 7/7: Deleting .mp4 files...
del /q *.mp4
echo .mp4 files deleted.

echo All steps completed.
pause