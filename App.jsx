import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import './App.css'
import Navbar from './Navbar'
import ListProducts from './ListProducts'
import SingleProduct from './SingleProduct'
import NewProduct from './NewProduct'
import { BrowserRouter, Route, Routes } from 'react-router-dom'

function App() {
  

  return (
    <>
      <BrowserRouter>
      <Navbar/>
      <Routes>
        <Route path="/" element={<ListProducts />} />
        <Route path="/tip/:id" element={<SingleProduct />} />
        <Route path="/uj-tip" element={<NewProduct />} />
      </Routes>
    </BrowserRouter>
    </>
  )
}

export default App
