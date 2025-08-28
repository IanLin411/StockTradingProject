import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Header from './components/Header';
import Footer from './components/Footer';
import Home from './pages/Home';
import Stocks from './pages/Stocks';
import Categories from './pages/Categories';

const App: React.FC = () => {
  return (
    <Router>
      <div>
        <Header />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/stocks" element={<Stocks />} />
          <Route path="/categories" element={<Categories />} />
        </Routes>
        <Footer />
      </div>
    </Router>
  );
};

export default App;