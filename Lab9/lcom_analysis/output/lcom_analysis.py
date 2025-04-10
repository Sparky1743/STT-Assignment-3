import pandas as pd

# Load the CSV file
csv_file = "TypeMetrics.csv"  # Replace with actual path
df = pd.read_csv(csv_file)

# Define thresholds
LCOM_THRESHOLD = 100  # High LCOM1 indicates low cohesion
HIGH_FRAGMENTATION_THRESHOLD = 1  # LCOM5 > 1 means high fragmentation

# Filter classes based on thresholds
high_lcom_classes = df[df["LCOM1"] > LCOM_THRESHOLD]

# Sort: High fragmentation classes first
high_lcom_classes = high_lcom_classes.sort_values(by="LCOM5", ascending=False)

# Analysis function
def analyze_class(row):
    class_name = row["Type Name"]
    lcom1 = row["LCOM1"]
    lcom5 = row["LCOM5"]

    print(f"Class: {class_name}")
    print(f"  - LCOM1: {lcom1}")
    print(f"  - LCOM5: {lcom5}")

    if lcom5 > HIGH_FRAGMENTATION_THRESHOLD:
        print("  ❗ High fragmentation: The class has methods that do not share fields.")
        print("  🔄 Consider functional decomposition: This class might be doing too much.")
    else:
        print("  ✅ Acceptable cohesion: The class might not require decomposition.")
    
    print("-" * 50)

# Apply analysis to each high-LCOM class
print("\n📊 High LCOM Class Analysis 📊\n")

# First, analyze **high-fragmentation classes**
high_fragmentation = high_lcom_classes[high_lcom_classes["LCOM5"] > HIGH_FRAGMENTATION_THRESHOLD]
high_fragmentation.apply(analyze_class, axis=1)

# Then, analyze **remaining high-LCOM classes**
remaining_classes = high_lcom_classes[high_lcom_classes["LCOM5"] <= HIGH_FRAGMENTATION_THRESHOLD]
remaining_classes.apply(analyze_class, axis=1)
