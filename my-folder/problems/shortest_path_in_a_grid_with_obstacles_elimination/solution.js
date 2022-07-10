class MinHeap {
  constructor() {
    this.store = [];
    this.visited = {}
  }

  isEmpty() {
    return this.store.length === 0;
  }

  peak() {
    return this.store[0];
  }

  push(value) {
    const { row, col, obstacles } = value;
    const posStr = `${row}-${col}`
    if (!this.visited.hasOwnProperty(posStr) || this.visited[posStr] < obstacles) {
      this.visited[posStr] = obstacles;
      this.store.push(value);
      this.heapifyUp(this.store.length - 1);
    }
  }

  pop() {
    if (this.store.length < 2) return this.store.pop();
    const value = this.store[0];
    this.store[0] = this.store.pop();
    this.heapifyDown(0);
    return value;
  }

  heapifyUp(child) {
    if (!child) return;
    const parent = Math.floor((child - 1) / 2);
    if (this.store[child].weight < this.store[parent].weight) {
      const temp = this.store[child];
      this.store[child] = this.store[parent];
      this.store[parent] = temp;
      this.heapifyUp(parent);
    }
  }

  heapifyDown(parent) {
    const childs = [1,2].map((x) => parent * 2 + x)
                        .filter((x) => x < this.store.length);
    let child = childs[0];
    if (childs[1] && this.store[childs[1]].weight < this.store[child].weight) {
      child = childs[1];
    }
    if (child && this.store[child].weight < this.store[parent].weight) {
      const temp = this.store[child];
      this.store[child] = this.store[parent];
      this.store[parent] = temp;
      this.heapifyDown(child);
    }
  }
}

/**
 * @param {number[][]} grid
 * @param {number} k
 * @return {number}
 */
var shortestPath = function(grid, k) {
  const heap = new MinHeap();
  const rowLen = grid.length;
  const colLen = grid[0].length;
  heap.push({ row: rowLen - 1, col: colLen - 1, weight: -1, steps: 0, obstacles: k })
  const directions = [[1,0],[0,1],[0,-1],[-1,0]];
  while (!heap.isEmpty()) {
    const { row, col, weight, steps, obstacles } = heap.pop();
    if (obstacles >= row + col - 1) return steps + row + col;
    directions.forEach(([down, right]) => {
      const nextRow = row + down;
      if ([-1, rowLen].includes(nextRow)) return;
      const nextCol = col + right;
      if ([-1, colLen].includes(nextCol)) return;
      const nextObstacles = grid[nextRow][nextCol] ? obstacles - 1 : obstacles;
      if (nextObstacles < 0) return;
      const nextWeight = nextRow + nextCol + steps + 1;
      heap.push({ row: nextRow, col: nextCol, weight: nextWeight, steps: steps + 1, obstacles: nextObstacles });
    })
  }
  return -1;
};