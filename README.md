# Change All Texture Max Size in Unity

This Unity editor script allows you to change the `Max Size` property for all textures in your project to a specified value with just a single click. It is particularly useful for optimizing texture sizes across your entire project, ensuring consistency and potentially reducing build sizes.

## How It Works

- **Menu Item**: The script adds a new menu item under `Tools/Change All Texture MaxSize` in the Unity Editor.
- **Texture Collection**: It searches for all textures in the project using Unity's `AssetDatabase.FindAssets` method.
- **Max Size Update**: For each texture found, the script updates the `Max Size` property to a predefined value (e.g., 512).
- **Reimport**: After changing the `Max Size`, the textures are reimported to apply the changes.

## Usage

1. **Add the Script**: Copy the script into your `Editor` folder in Unity. If you don't have an `Editor` folder, create one under your `Assets` directory.

2. **Modify the Max Size Value**: By default, the script sets the `Max Size` to 512. You can modify the `newMaxSize` variable within the script to set a different value.

   ```csharp
   int newMaxSize = 512; // Change this value to your desired max size
   ```

3. **Run the Script**:
   - In Unity, navigate to the menu: `Tools > Change All Texture MaxSize`.
   - Click on it to execute the script. This will iterate through all textures in your project and change their `Max Size` to the value specified in the script.

4. **Check the Console**: After the process completes, a message will appear in the Console confirming that all texture `Max Size` values have been changed.

   ```plaintext
   All Texture MaxSize Changed to: 512
   ```

## Example

Here's how the script operates in detail:

1. The script defines a new menu item under `Tools` for easy access.
2. It searches for all assets of type `Texture` within the project.
3. For each texture, the script loads the asset, accesses its `TextureImporter`, and sets the `maxTextureSize` property to the specified value.
4. The script reimports each texture to apply the changes, ensuring the new size is effective.
5. A confirmation message is printed in the Console once the process is complete.

## Important Notes

- **Backup**: Before running this script, consider making a backup of your project, especially if you're working on a large project with many textures. Changing the `Max Size` can affect the quality and performance of textures.
- **Customization**: You can modify the script to apply different settings or target specific textures by changing the search query or adding additional logic to filter textures based on their properties.

## Compatibility

- Unity 2020.1 and above (may work on earlier versions, but not guaranteed).
  
## License

This script is open-source and available under the MIT License. Feel free to modify and use it as needed.

## Conclusion

This script provides a quick and efficient way to manage the `Max Size` property of all textures in your Unity project. Whether you're optimizing for mobile platforms or simply ensuring consistent texture sizes, this tool can save you a significant amount of time.
