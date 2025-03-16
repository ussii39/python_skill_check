process.stdin.resume();
process.stdin.setEncoding("utf8");
// 自分の得意な言語で
// Let's チャレンジ！！
var lines = [];
var reader = require("readline").createInterface({
  input: process.stdin,
  output: process.stdout,
});
reader.on("line", (line) => {
  lines.push(line);
});
reader.on("close", () => {
  // N
  // C_1 C_2 ... C_N
  //   console.log(lines[0]);
  const N = Number(lines[0]);
  const C = lines[1].split(" ").map((x) => Number(x));
  C.sort((a, b) => a - b);

  const groups = [];
  let prev_num = C[0];
  let currentGroup = [C[0]];
  for (var i = 1; i < N; i++) {
    if (prev_num + 1 == C[i]) {
      currentGroup.push(C[i]);
    } else {
      //   currentGroup.push(C[i])
      groups.push(currentGroup);
      currentGroup = [C[i]];
    }
    //   console.log(currentGroup)
    prev_num = C[i];
  }
  groups.push(currentGroup);

  //   console.log(groups)
  // 各グループのスコアを計算して合計
  let totalScore = 0;
  for (let group of groups) {
    // グループ内の最大値がスコア
    totalScore += Math.max(...group);
  }

  // 結果を出力
  console.log(totalScore);
});
