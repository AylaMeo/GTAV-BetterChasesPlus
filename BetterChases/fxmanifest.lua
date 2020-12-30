-- Manifest data
fx_version 'bodacious'
game 'gta5'

-- Resource stuff
name 'Better Chases'
description 'Better Police Chases'
version 'v0'
author 'Ayla'
url 'https://github.com/AylaMeo/BetterChases'

-- Adds additional logging, useful when debugging issues.
client_debug_mode 'true'
server_debug_mode 'true'


-- Files & scripts & dependencies
file '*.dll'

client_script {
    '*.net.dll',
}