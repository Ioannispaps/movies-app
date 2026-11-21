import { useEffect, useState } from "react";
import "./App.css";

const API_URL = "http://localhost:5012/api/movies";

function App() {
  const [movies, setMovies] = useState([]);
  const [title, setTitle] = useState("");
  const [director, setDirector] = useState("");
  const [year, setYear] = useState("");
  const [error, setError] = useState("");

  const loadMovies = async () => {
    try {
      const response = await fetch(API_URL);
      const data = await response.json();
      setMovies(data);
      setError("");
    } catch {
      setError("Δεν μπόρεσα να συνδεθώ με το API. Τρέχει;");
    }
  };

  useEffect(() => {
    loadMovies();
  }, []);

  const handleSubmit = async (e) => {
    e.preventDefault();
    await fetch(API_URL, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ title, director, year: Number(year) }),
    });
    setTitle("");
    setDirector("");
    setYear("");
    loadMovies();
  };

  return (
    <div className="container">
      <h1>🎬 Ταινίες</h1>

      {error && <p className="error">{error}</p>}

      <form onSubmit={handleSubmit}>
        <input
          placeholder="Τίτλος"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
          required
        />
        <input
          placeholder="Σκηνοθέτης"
          value={director}
          onChange={(e) => setDirector(e.target.value)}
          required
        />
        <input
          placeholder="Έτος"
          type="number"
          value={year}
          onChange={(e) => setYear(e.target.value)}
          required
        />
        <button type="submit">Προσθήκη</button>
      </form>

      <ul>
        {movies.map((m) => (
          <li key={m.id}>
            <strong>{m.title}</strong>
            <span>
              {m.director} · {m.year}
            </span>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;