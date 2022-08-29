# Audio
Merubah dan menambahkan fungsi untuk "Load" dan "Unload" BGM

# Sprite Atlas
Menambahkan satu script untuk menghandle sprite loading
Membuat satu SpriteAtlas untuk dua button di Scene Menu

# Pooling
Menggunakan object pooling dengan merubah script mushroomspawner dan Mushroom untuk melakukan SetActive false/true

# Batching
Pada Menu Scene tidak ada perbedaan yang signifikan karena texture yang diload hanya dua Texture, yang berbeda hanya pada bagian bacthing yang berkurang 1
Pada Game Scene terjadi perbedaan setelah dan sebelum di lakukan static batching, dimana 
	Sebelum : Nilai setpass rendah dengan batching tinggi
	Sesudah : Nilai setpass tinggi dan batching rendah
