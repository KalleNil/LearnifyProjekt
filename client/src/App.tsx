import React, { useCallback, useEffect, useState } from 'react';
import { Route, Switch } from 'react-router-dom';
import './sass/main.scss';
import Navigation from './components/Navigation';
import 'antd/dist/antd.min.css';
import HomePage from './pages/Homepage';
import Login from './pages/Login';
import DetailPage from './pages/DetailPage';
import Categories from './components/Categories';
import CategoryPage from './pages/CategoryPage';
import DescriptionPage from './pages/DescriptionPage';
import BasketPage from './pages/BasketPage';
import { useAppDispatch } from './redux/store/configureStore';
import { fetchBasketAsync } from './redux/slice/basketSlice';
import Dashboard from './components/Dashboard';
import { fetchCurrentUser } from './redux/slice/userSlice';
import PrivateRoute from './components/PrivateRoute';
import Loading from './components/Loading';
import CheckoutPage from './pages/CheckoutPage';
import CoursePage from './pages/CoursePage';
import InstructorPage from './pages/InstructorPage';
import CreateCourse from './pages/CreateCourse';
import { getCategoriesAsync } from './redux/slice/categorySlice';
import SectionPage from './pages/SectionPage';

function App() {
  const dispatch = useAppDispatch();
  const [loading, setLoading] = useState(true);

  const appInit = useCallback(async () => {
    try {
      await dispatch(fetchCurrentUser());
      await dispatch(fetchBasketAsync());
      await dispatch(getCategoriesAsync());
    } catch (error: any) {
      console.log(error);
    }
  }, [dispatch]);

  useEffect(() => {
    appInit().then(() => setLoading(false));
  }, [appInit]);

  if (loading) return <Loading />;

  return (
    <>
      <Navigation />
      <Route exact path="/" component={Categories} />
      <Switch>
        <Route exact path="/" component={HomePage} />
        <Route exact path="/course/:id" component={DescriptionPage} />
        <Route exact path="/basket" component={BasketPage} />
        <Route exact path="/category/:id" component={CategoryPage} />
        <Route exact path="/login" component={Login} />
        <Route exact path="/detail" component={DetailPage} />
        <PrivateRoute exact path="/checkout" component={CheckoutPage} />
        <PrivateRoute exact path="/profile" component={Dashboard} />
        <PrivateRoute exact path="/learn/:course/:lecture" component={CoursePage} />
        <PrivateRoute exact path="/instructor" component={InstructorPage} />
        <PrivateRoute exact path="/instructor/course" component={CreateCourse} />
        <PrivateRoute exact path="/:course/lectures" component={SectionPage} />
      </Switch>
    </>
  );
}
export default App;
