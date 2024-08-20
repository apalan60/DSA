# Stack
- **Stack** 是一種資料結構，具有 **後進先出 (LIFO)** 的特性。
- 常見操作：
    - `Push`：將元素放入堆疊頂部。
    - `Pop`：取出堆疊頂部的元素。
    - `Peek/Top`：查看但不移除堆疊頂部的元素。
    - `IsEmpty`：檢查堆疊是否為空。

## 瀏覽器的「返回」與「前進」功能
- **Back 堆疊**：保存返回操作前的頁面。
- **Forward 堆疊**：保存返回操作後的頁面。

### 操作流程：
1. **瀏覽新頁面**：
    - 將當前頁面壓入 `Back 堆疊`，並清空 `Forward 堆疊`。

2. **返回 (Back)**：
    - 將當前頁面壓入 `Forward 堆疊`，並從 `Back 堆疊` 中彈出上一頁。

3. **前進 (Forward)**：
    - 將當前頁面壓入 `Back 堆疊`，並從 `Forward 堆疊` 中彈出下一頁。

### 具體例子：
- 假設瀏覽順序為：`Page A → Page B → Page C`。

  **第一次「返回」**：
    - 當你從 **Page C** 點擊「返回」：
        - **Page C** 被壓入 `Forward 堆疊`。
        - `Back 堆疊` 中的 **Page B** 彈出並成為當前頁面。
        - 當前狀態：
            - `Back 堆疊`：[Page A]
            - `Forward 堆疊`：[Page C]

  **第二次「返回」**：
    - 當你從 **Page B** 再次點擊「返回」：
        - **Page B** 被壓入 `Forward 堆疊`。
        - `Back 堆疊` 中的 **Page A** 彈出並成為當前頁面。
        - 當前狀態：
            - `Back 堆疊`：[]
            - `Forward 堆疊`：[Page C, Page B]

  **兩次「前進」**：
    - 第一次點擊「前進」：
        - **Page A** 被壓入 `Back 堆疊`。
        - `Forward 堆疊` 中的 **Page B** 彈出並成為當前頁面。
        - 當前狀態：
            - `Back 堆疊`：[Page A]
            - `Forward 堆疊`：[Page C]

    - 第二次點擊「前進」：
        - **Page B** 被壓入 `Back 堆疊`。
        - `Forward 堆疊` 中的 **Page C** 彈出並成為當前頁面。
        - 當前狀態：
            - `Back 堆疊`：[Page A, Page B]
            - `Forward 堆疊`：[]