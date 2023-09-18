from PIL import Image

def convert_png_to_ico(png_file_path, ico_file_path):
    with Image.open(png_file_path) as im:
        im.save(ico_file_path + ".ico", format="ICO", sizes=[(32, 32)])

convert_png_to_ico("logoLight.png","icon")