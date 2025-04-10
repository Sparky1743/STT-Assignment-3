import json

# Load JSON data
with open("requests_deps.json", "r") as file:  # Change to actual file path
    data = json.load(file)

# Initialize dictionaries for fan-in and fan-out
fan_in = {module: 0 for module in data}
fan_out = {module: len(details.get("imports", [])) for module, details in data.items()}

# Calculate fan-in by counting appearances in "imported_by"
for module, details in data.items():
    if "imported_by" in details:
        for importer in details["imported_by"]:
            if importer in fan_in:
                fan_in[module] += 1

# Display results
print("\nModule Dependency Metrics:")
print("-" * 40)
for module in data.keys():
    print(f"Module: {module}")
    print(f"  Fan-In  (Imported by): {fan_in[module]}")
    print(f"  Fan-Out (Imports)    : {fan_out[module]}")
    print("-" * 40)

# Optional: Save results to a JSON file
output = {module: {"fan_in": fan_in[module], "fan_out": fan_out[module]} for module in data}
with open("fan_in_out_results.json", "w") as outfile:
    json.dump(output, outfile, indent=4)

print("\nResults saved to fan_in_out_results.json")
