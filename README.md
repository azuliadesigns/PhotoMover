# PhotoMover
A tool which reads the DateTaken EXIF Meta tag and moves photos into date based folders

PhotoMover scans a specified directory for all JPEG and Canon RAW (.cr2) files. It then reads the DateTaken property from the Meta data and creates a folder (yyyy-MM-dd by default) and the photo is then moved into this folder. This is very useful for organising lots of photos quickly.

Please note that this is not a finished product by any means. I wrote this in a couple of hours to get a job done quickly. I'm sharing it here in case the code or application are useful to anyone else. If there is enough interest I can develop this further into a more stable offering.

# Usage
First launch the program from the bin/Debug folder and select the source directory. This is done by clicking on the "Select" button next to "Source Folder" text box. You can also paste in a folder path from Windows Explorer.

If you wish to move photos to a folder under the source directory, you can leave the destination blank, otherwise photos will be moved into folders under the directory you select here.

Click the `Preview` button to see a list of the images found, the values for DateTaken and the new destination name. 

If all looks OK you can then click the "Move" button to start the photo moving process.

If you wish to copy files instead of moving, you can select the "Copy" option.

The other option you can change is the date format.

- `yyyy-MM-dd` is the default. This will create `destination\2018-11-13\Image1.jpg`
- `yyyy\MM` can also be used. This will create a year folder and a month folder, for example, `destination\2018\11\Image1.jpg`
- `yyyy\MM\dd` as above, except it will create a day folder as well, for example, `destination\2018\11\13\Image1.jpg`

Here is a full list of the most useful format strings you can use:

- `d` -> Day of the month as a number from 1 through 31.
- `dd` -> Day of the month as a number from 01 through 31.
- `ddd` -> Abbreviated name of the day (Mon, Tues, Wed etc).
- `dddd` -> Full name of the day (Monday, Tuesday etc).
- `M` -> Month number (eg.3)
- `MM` -> Month number with leading zero (eg.04)
- `MMM` -> Abbreviated Month Name (e.g. Dec)
- `MMMM` -> Full month name (e.g. December)
- `y` -> Year, no leading zero (e.g. 2015 would be 15)
- `yy` -> Year, leading zero (e.g. 2015 would be 015)
- `yyy` -> Year, (e.g. 2015)
- `yyyy` -> Year, (e.g. 2015)

A full list of available format strings can be found here - https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings. Just remember that the format has to be a valid file path.

# Future Work
Still to be implemented is recursive processing of images, more RAW formats supported and reading in more tags for extra filename operations. Reading the GPS location and converting this to a country/region/city/date filename structure is the eventual goal.

# Comments and Feedback
Was this tool useful in any way? Do you have any suggestions for improvements, or did you find something that didn't work? Let me know and I'll do my best to incorporate your feedback.
