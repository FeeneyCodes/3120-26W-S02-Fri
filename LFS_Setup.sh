echo "Finding files larger than 49 Mbytes..."
python LST_FindLargeFile.py > TrackTheseLargeFiles.sh
git lfs install
echo "Adding large files to track (if any)"
./TrackTheseLargeFiles.sh
echo "Updating gitattributes"
git add .gitattributes
echo "All done. Ready to add, commit, and push"