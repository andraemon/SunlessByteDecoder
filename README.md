# Use
The executable can either be called from the command line, have a file or directory dragged onto it, or run in a folder containing .bytes of .json files from Sunless Skies. Command line arguments are enumerated below.

If dragging files onto the executable, either an individual file or a directory can be passed. When a single file is passed, the program will encode or decode it based on its file extension. Otherwise, it will encode or decode files in the passed directory according to the file extension of whichever file it sees first.

If run inside a directory containing .bytes or.json files, it will encode or decode files in the directory according to the file extension of whichever file it sees first. 

Resulting files will always be created inside a new directory called `data` next to the executable.

# Arguments
`--decode=<path_to_file>` - Accepts as input either a single .bytes file or a directory containing .bytes files. If a single file is passed, decodes it to the corresponding .json file. If a directory is passed, decodes all valid .bytes files it contains to .json files.

`--encode=<path_to_file>` - Accepts as input either a single .json file or a directory containing .json files. If a single file is passed, encodes it to the corresponding .bytes file. If a directory is passed, encodes all valid .json files it contains to .bytes files.

# Copyright
All code in this repository is the intellectual property of Failbetter Games Ltd.

Copyright (c) 2021, Failbetter Games Ltd.
