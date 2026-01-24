from pathlib import Path

def find_large_files_pathlib(directory, min_size_mb):
    path = Path(directory)
    min_size_bytes = min_size_mb * 1024 * 1024
    
    # rglob('*') searches recursively for all files
    for file in path.rglob('*'):
        try:
            if file.is_file() and not file.is_symlink():
                size = file.stat().st_size
                if size > min_size_bytes:
                    print(f"git lfs track \"{file}\"")
        except (PermissionError, FileNotFoundError):
            continue

find_large_files_pathlib('.', 49)