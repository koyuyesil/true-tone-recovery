import tkinter as tk

# Model adları ve özellik adları ile ilişkilendirilmiş sayı aralıkları
data = {
    "Model1": {
        "LCMSN": (0, 57),
        "GaussSN": (15104, 15130),
        "MtSN": (14903, 14946),
        "TrueToneSN": (16320, 16348)
    },
    "Model2": {
        "LCMSN": (0, 56),
        "GaussSN": (15104, 15129),
        "MtSN": (14903, 14946),
        "TrueToneSN": (16320, 16348)
    },
    # Diğer modelleri buraya ekleyin
}

# Fark hesaplama fonksiyonu
def calculate_difference():
    selected_model = model_var.get()
    selected_feature = feature_var.get()

    if selected_model in data and selected_feature in data[selected_model]:
        range_start, range_end = data[selected_model][selected_feature]
        difference.set(range_end - range_start)

# Tkinter uygulamasını oluştur
app = tk.Tk()
app.title("Model Aralık Farkı Hesaplayıcı")

# Model seçimini içeren ComboBox
model_label = tk.Label(app, text="Model Seçin:")
model_label.pack()
model_var = tk.StringVar()
model_var.set(list(data.keys())[0])  # Başlangıçta ilk modeli seçili olarak göster
model_dropdown = tk.OptionMenu(app, model_var, *data.keys())
model_dropdown.pack()

# Özellik seçimini içeren ComboBox
feature_label = tk.Label(app, text="Özellik Seçin:")
feature_label.pack()
feature_var = tk.StringVar()
feature_var.set(list(data[model_var.get()].keys())[0])  # Başlangıçta ilk özelliği seçili olarak göster
feature_dropdown = tk.OptionMenu(app, feature_var, *data[model_var.get()].keys())
feature_dropdown.pack()

# Farkı gösteren metin kutusu
difference_label = tk.Label(app, text="Aralık Farkı:")
difference_label.pack()
difference = tk.IntVar()
difference.set(0)
difference_entry = tk.Entry(app, textvariable=difference, state="readonly")
difference_entry.pack()

# Farkı hesapla düğmesi
calculate_button = tk.Button(app, text="Farkı Hesapla", command=calculate_difference)
calculate_button.pack()

# Uygulamayı başlat
app.mainloop()
