-- Manifest data
fx_version 'bodacious'
game 'gta5'

-- Resource stuff
name 'BetterChases+'
description 'BetterChases+'
version 'v0'
author 'Eddlm & Guadmaz & Daimian' -- credits for others, not me c:
url 'https://github.com/AylaMeo/GTAV-BetterChasesPlus'

-- Adds additional logging, useful when debugging issues.
client_debug_mode 'true'
server_debug_mode 'true'


-- Files & scripts & dependencies
file '*.dll'
file 'System.Drawing.dll'

client_script {
    '*.net.dll',
}