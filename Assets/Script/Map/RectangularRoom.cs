using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RectangularRoom {
  public int id, x, y, width, height;

  public RectangularRoom(int x, int y, int width, int height, int id = 0) {
    this.x = x;
    this.y = y;
    this.width = width;
    this.height = height;
    this.id = id;
  }

  public Vector2Int Center() => new Vector2Int(x + width / 2, y + height / 2);


  //  Return the area of this room as a Bounds.
  
  public Bounds GetBounds() => new Bounds(new Vector3(x, y, 0), new Vector3(width, height, 0));


  // Return the area of this room as BoundsInt
  
  public BoundsInt GetBoundsInt() => new BoundsInt(new Vector3Int(x, y, 0), new Vector3Int(width, height, 0));


  // Return True if this room overlaps with another RectangularRoom.
  
  public bool Overlaps(List<RectangularRoom> otherRooms) {
    foreach (RectangularRoom otherRoom in otherRooms)
      if (GetBounds().Intersects(otherRoom.GetBounds()))
        return true;

    return false;
  }
}