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
  // t_1 e_1 m_1 s_1 j_1 g_1
  // t_2 e_2 m_2 s_2 j_2 g_2
  // ...
  // t_N e_N m_N s_N j_N g_N
  // 全科目の合計得点が 350 点以上
  // 理系の受験者の場合は理系 2 科目 (数学、理科) の合計得点が 160 点以上
  // 文系の受験者の場合は文系 2 科目 (国語、地理歴史) の合計得点が 160 点以上
  const N = Number(lines[0]);
  let passed_count = 0;
  for (let t = 1; t <= N; t++) {
    // console.log(lines[t].split())
    const values = lines[t].split(" ");
    const [t_1, ...numbers] = lines[t].split(" ");
    const [e_1, m_1, s_1, j_1, g_1] = numbers.map(Number);
    // console.log(t_1,e_1, m_1, s_1, j_1, g_1)
    sub_score = 0;
    all_sub_score = e_1 + m_1 + s_1 + j_1 + g_1;

    if (t_1 === "s") {
      sub_score += m_1 + s_1;
    } else if (t_1 === "l") {
      sub_score += j_1 + g_1;
    }
    // console.log(sub_score,all_sub_score)
    if (all_sub_score >= 350 && sub_score >= 160) {
      passed_count += 1;
    }
  }
  console.log(passed_count);
});
