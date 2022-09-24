import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js';
import Checkout from '../components/Checkout';

const stripePromise = loadStripe('pk_test_51LlLIuJQMtDY1AYpaw6BXeu8zPAdttooMRT5rP0voCkBrofjQtOgr49K4Qzz8XqWp3TITLXIqlwYxETcqLcKpquf00E6hmMjKA');

export default function CheckoutWrapper() {
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}